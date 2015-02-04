using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Helpers.Enums;
namespace BugTracker.Repository
{
   public class TicketRepository : ITicketRepository
    {
        PeopleRepository peopleRepository;
        CommentRepository commentRepository;
        private List<Ticket> tickets;
        TicketRepository()
        {
            peopleRepository = new PeopleRepository();
            commentRepository = new CommentRepository();

            tickets = new List<Ticket>
        {
            new Ticket
            {
                idTicket = 1,
                Title = "Create Gerber .Net API Documentation",
                Type = TypeTicket.Task,
                Priority = Priority.Minor,
                Labels = "None",
                Sprint = new Sprint
                {
                    IdSprint=1,
                    Description ="Sprint 1 Back-end planning",
                    EndDate = new DateTime(2015,02,07)
                },
                Status = Status.Todo,
                Resolution = Resolution.Unresolved,
                DateCreated = new DateTime(2015,01,19),
                DateUpdated = new DateTime(2015,01,19),
                Description = "fghjhjkjr",
                Assignee = peopleRepository.people.Where(x => x.IdPeople == 1).First(),
                Reporter = peopleRepository.people.Where(x => x.IdPeople == 2).First(),
                Comments = commentRepository.comments.Where(x=> x.IdTicket == 1).ToList() 
            },
             new Ticket
            {
                idTicket = 2,
                Title = "Add file.txt to site",
                Type = TypeTicket.Bug,
                Priority = Priority.Blocker,
                Labels = "None",
                Sprint = new Sprint
                {
                    IdSprint=1,
                    Description ="Sprint 1 Back-end planning",
                    EndDate = new DateTime(2015,02,07)
                },
                Status = Status.Todo,
                Resolution = Resolution.Unresolved,
                DateCreated = new DateTime(2015,01,19),
                DateUpdated = new DateTime(2015,01,19),
                Description = "fghjhjkjr",
                Assignee = peopleRepository.people.Where(x => x.IdPeople == 2).First(),
                Reporter = peopleRepository.people.Where(x => x.IdPeople == 2).First(),
                Comments = commentRepository.comments.Where(x=> x.IdTicket == 2).ToList() 
            }
        };
        }
        private static TicketRepository repo = new TicketRepository();

        public static ITicketRepository getRepository()
        {
            return repo;
        }

        public IEnumerable<Ticket> GetAll()
        {
            return tickets;
        }

        public Ticket Get(int id)
        {
            var matches = tickets.Where(x => x.idTicket == id);
            return matches.Count() > 0 ? matches.First() : null;
        }

        public bool Update(Ticket item)
        {
            Ticket ticket = Get(item.idTicket);
            if (ticket != null)
            {
                ticket.Title = item.Title;
                ticket.Type = item.Type;
                ticket.Priority = item.Priority;
                ticket.Labels = item.Labels;
                ticket.Sprint = item.Sprint;
                ticket.Status = item.Status;
                ticket.Resolution = item.Resolution;
                ticket.Reporter = item.Reporter;
                ticket.DateCreated = item.DateCreated;
                ticket.DateUpdated = item.DateUpdated;
                ticket.Description = item.Description;
                ticket.Assignee = item.Assignee;
                ticket.Resolution = item.Resolution;
                ticket.Comments = item.Comments;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
