using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace BugTracker.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private string ConnectionString = "Data Source=juli;Initial Catalog=bagTrackerDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

        public IEnumerable<Ticket> GetAll()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var listTickets = conn.Query<Ticket, TypeTicket, Priority, Status, Resolution, User, User, Ticket>(@"
                                                                                                                SELECT t.idTicket, t.title, 
                                                                                                                typ.id, typ.title, typ.image,
                                                                                                                p.id, p.title, p.image,                                                                                                                
                                                                                                                s.id, s.title,
                                                                                                                r.id, r.title,
                                                                                                                a.idUser, a.fullname, a.image,
                                                                                                                rep.idUser, rep.fullname, rep.image    
                                                                                                                FROM tickets t 
                                                                                                                INNER JOIN types typ ON typ.id = t.idType
                                                                                                                INNER JOIN priorities p ON t.idPriority = p.id
                                                                                                                INNER JOIN statuses s ON t.idStatus = s.id
                                                                                                                INNER JOIN resolutions r ON t.idResolution = r.id 
                                                                                                                INNER JOIN users a ON a.idUser = t.idAssignee
                                                                                                                INNER JOIN users rep ON rep.idUser = t.idReporter ",
                                                                                                                (t, types, p, s, r, a, reporter) =>
                                                                                                                {
                                                                                                                    t.Type = types;
                                                                                                                    t.Priority = p;
                                                                                                                    t.Status = s;
                                                                                                                    t.Resolution = r;
                                                                                                                    t.Assignee = a;
                                                                                                                    t.Reporter = reporter;
                                                                                                                    return t;
                                                                                                                },
                                                                                                                splitOn: "Id, Id, Id, Id, IdUser, IdUser");
                conn.Close();
                return listTickets;
            }

            // return tickets;
        }

        public Ticket Get(string id)
        {
            //var matches = tickets.Where(x => x.idTicket == id);
            //return matches.Count() > 0 ? matches.First() : null;
            var sql = String.Format(@"SELECT t.idTicket, t.title, t.description,
                                             typ.id, typ.title, typ.image,
                                             p.id, p.title, p.image,                                                                                                                
                                             s.id, s.title,
                                             r.id, r.title,
                                             a.idUser, a.fullname, a.image,
                                             rep.idUser, rep.fullname, rep.image    
                                      FROM tickets t 
                                             INNER JOIN types typ ON typ.id = t.idType
                                             INNER JOIN priorities p ON t.idPriority = p.id
                                             INNER JOIN statuses s ON t.idStatus = s.id
                                             INNER JOIN resolutions r ON t.idResolution = r.id 
                                             INNER JOIN users a ON a.idUser = t.idAssignee
                                             INNER JOIN users rep ON rep.idUser = t.idReporter
WHERE t.idTicket = @id");
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var ticket = conn.Query<Ticket, TypeTicket, Priority, Status, Resolution, User, User, Ticket>(sql, (t, types, p, s, r, a, reporter) =>
                                                                                                                       {
                                                                                                                           t.Type = types;
                                                                                                                           t.Priority = p;
                                                                                                                           t.Status = s;
                                                                                                                           t.Resolution = r;
                                                                                                                           t.Assignee = a;
                                                                                                                           t.Reporter = reporter;
                                                                                                                           return t;
                                                                                                                       }, new { id },
                                                                                                                splitOn: "Id, Id, Id, Id, IdUser, IdUser").FirstOrDefault();
                conn.Close();
                return ticket;
            }
        }

        public bool Update(Ticket item)
        {
            //    Ticket ticket = Get(item.idTicket);
            //    if (ticket != null && item.Status.IdStatus != 0)
            //    {
            //        ticket.Title = item.Title;
            //        ticket.TitleType = item.TitleType;
            //        ticket.TitlePriority = item.TitlePriority;
            //        ticket.Labels = item.Labels;
            //        ticket.Sprint = item.Sprint;
            //        ticket.Status = item.Status;
            //        ticket.TitleResolution = item.TitleResolution;
            //        ticket.Reporter = item.Reporter;
            //        ticket.DateCreated = item.DateCreated;
            //        ticket.DateUpdated = item.DateUpdated;
            //        ticket.Description = item.Description;
            //        ticket.Assignee = item.Assignee;
            //        ticket.TitleResolution = item.TitleResolution;
            //        //ticket.Comments = item.Comments;
            //        return true;
            //    }
            //    else if (ticket != null)
            //    {
            //        Status status = statusRepository.(item.GetStatusStatus.Title);
            //        ticket.Status = statusRepository.statuses.Where(x => x.IdStatus == status.IdStatus).First();
            //        return true;
            //    }
            //    else { return false; }

            if (item.Title != null)
            {
                //                var sql = String.Format(@"INSERT INTO tickets (title, idType, idPriority, idResolution, description, idAssignee, idReporter) 
                //                                             VALUES('{0}', {1}, {2}, {3}, {4}, {5}, {6})",
                //                                       item.Title, item.Type.Id, item.Priority.Id, item.Resolution.Id, item.Description, item.Assignee.IdUser, item.Reporter.IdUser);
                var sql = String.Format(@" UPDATE tickets SET title = '{0}', idType = {1}, idPriority = {2}, idResolution = {3}, idAssignee = {4}, idReporter = {5} WHERE idTicket = {6}",
                    item.Title, item.Type.Id, item.Priority.Id, item.Resolution.Id, item.Assignee.IdUser, item.Reporter.IdUser, item.idTicket);
                using (var conn = new SqlConnection(ConnectionString))
                {
                    var result = conn.Execute(sql);
                    return result > 0 ? true : false;
                }
            }
            else
            {
                var sql = String.Format(@" UPDATE tickets SET idStatus = {0} WHERE idTicket = {1}",
                    item.Status.Id, item.idTicket);
                using (var conn = new SqlConnection(ConnectionString))
                {
                    var result = conn.Execute(sql);
                    return result > 0 ? true : false;
                }
            }
        }
    }
}
