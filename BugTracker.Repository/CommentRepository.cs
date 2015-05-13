using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace BugTracker.Repository
{
    public class CommentRepository
    {
        private string ConnectionString = "Data Source=juli;Initial Catalog=bagTrackerDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

        // static public List<Comment> comments = new List<Comment>
        //{
        //    new Comment
        //    {
        //        IdTicket = "GAR-4",
        //        Comment = "qweetgkd"
        //    },
        //    new Comment
        //    {
        //        IdTicket = "GAR-4",
        //        Comment = "asercv kj vef "
        //    },
        //     new Comment
        //    {
        //        IdTicket = "GAR-3",
        //        Comment = "There are no comments yet on this issue."
        //     },
        //      new Comment
        //    {
        //        IdTicket = "GAR-1",
        //        Comment = "There are no comments yet on this issue."
        //     },
        //       new Comment
        //    {
        //        IdTicket = "GAR-2",
        //        Comment = "begth ghjki asdec "
        //     }
        //};


        public bool AddComment(Comment comment)
        {
            //    comments.Add(comment);
            //    var ticket = TicketRepository.getRepository().GetAll().Where(x => x.idTicket == comment.IdTicket).First();
            //    ticket.Comments = comments.Where(x => x.IdTicket == ticket.idTicket).ToList();
            using (var conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    int result = conn.Execute("insert into comments(idTicket,comments) values(@idTicket, @comment)", new { @idTicket = comment.IdTicket, @comment = comment.Comments });
                    return result != -1 ? true : false;
                }
                catch
                {
                    return false;
                }
            }
        }
        public List<Comment> GetComments(int idTicket)
        {
            //    comments.Add(comment);
            //    var ticket = TicketRepository.getRepository().GetAll().Where(x => x.idTicket == comment.IdTicket).First();
            //    ticket.Comments = comments.Where(x => x.IdTicket == ticket.idTicket).ToList();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var listComments = conn.Query<Comment>("SELECT * FROM comments WHERE idTicket = @idTicket", new { @idTicket = idTicket }).ToList();
                return listComments;
            }
        }


        public List<Comment> GetComments()
        {
            var sql = String.Format(@"SELECT * FROM comments");
            using (var conn = new SqlConnection(ConnectionString))
            {
                var listComments = conn.Query<Comment>(sql).ToList();
                return listComments;
            }
            //return comments;
        }
    }
}
