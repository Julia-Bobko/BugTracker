using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Repository
{
    public class TicketRepository : ITicketRepository
    {
        static List<Ticket> tickets;
        UserRepository userRepository;
        CommentRepository commentRepository;
        StatusRepository statusRepository;
        ResolutionRepository resolutionRepository;
        TypeTicketRepository typeTicketRepository;
        PriorityRepository priorityRepository;

        TicketRepository()
        {
            commentRepository = new CommentRepository();
            userRepository = new UserRepository();
            statusRepository = new StatusRepository();
            resolutionRepository = new ResolutionRepository();
            typeTicketRepository = new TypeTicketRepository();
            priorityRepository = new PriorityRepository();

            tickets = new List<Ticket>
        {
            new Ticket
            {
                idTicket = "GAR-1",
                Title = "Create Gerber .Net API Documentation",
                Type = typeTicketRepository.typeTickets[0],
                Priority = priorityRepository.priorities[0],
                Labels = "None",
                Sprint = new Sprint
                {
                    IdSprint=1,
                    Description ="Sprint 1 Back-end planning",
                    EndDate = new DateTime(2015,02,07)
                },
                Status = statusRepository.statuses[0],
                Resolution = resolutionRepository.resolutions[0],
                DateCreated = new DateTime(2015,01,19),
                DateUpdated = new DateTime(2015,01,19),
                Description = "This will help you organize the structure of your .net application to communicate with the API and the front-end.",
                Assignee = userRepository.users.Where(x => x.IdUser == 1).First(),
                Reporter = userRepository.users.Where(x => x.IdUser == 3).First(),
                Comments = CommentRepository.comments.Where(x=> x.IdTicket == "GAR-1").ToList()                
            },
             new Ticket
            {
                idTicket = "GAR-4",
                Title = "Add file.txt to site",
                Type = typeTicketRepository.typeTickets[1],
                Priority = priorityRepository.priorities[1],
                Labels = "None",
                Sprint = new Sprint
                {
                    IdSprint=1,
                    Description ="Sprint 1 Back-end planning",
                    EndDate = new DateTime(2015,02,07)
                },
                Status = statusRepository.statuses[3],
                Resolution = resolutionRepository.resolutions[1],
                DateCreated = new DateTime(2015,01,19),
                DateUpdated = new DateTime(2015,01,19),
                Description = "rtjn mikk vfbg tarket nj",
                Assignee = userRepository.users.Where(x => x.IdUser == 2).First(),
                Reporter = userRepository.users.Where(x => x.IdUser == 1).First(),
                Comments = CommentRepository.comments.Where(x=> x.IdTicket == "GAR-4").ToList() 
            },
             new Ticket
            {
                idTicket = "GAR-2",
                Title = "Domain/SSL for Grow up Application",
                Type = typeTicketRepository.typeTickets[0],
                Priority = priorityRepository.priorities[1],
                Labels = "None",
                Sprint = new Sprint
                {
                    IdSprint=1,
                    Description ="Sprint 1 Back-end planning",
                    EndDate = new DateTime(2015,02,07)
                },
                Status = statusRepository.statuses[5],
                Resolution = resolutionRepository.resolutions[1],
                DateCreated = new DateTime(2015,01,19),
                DateUpdated = new DateTime(2015,01,19),
                Description = "fghjhjkjr",
                Assignee = userRepository.users.Where(x => x.IdUser == 4).First(),
                Reporter = userRepository.users.Where(x => x.IdUser == 5).First(),
                Comments = CommentRepository.comments.Where(x=> x.IdTicket == "GAR-2").ToList() 
            },
            new Ticket
            {
                idTicket = "GAR-3",
                Title = "Create Gerber .Net API Framework to communicate with",
                Type = typeTicketRepository.typeTickets[0],
                Priority = priorityRepository.priorities[0],
                Labels = "None",
                Sprint = new Sprint
                {
                    IdSprint=1,
                    Description ="Sprint 1 Back-end planning",
                    EndDate = new DateTime(2015,02,07)
                },
                Status = statusRepository.statuses[5],
                Resolution = resolutionRepository.resolutions[0],
                DateCreated = new DateTime(2015,01,19),
                DateUpdated = new DateTime(2015,01,19),
                Description = "fghjhjkjr",
                Assignee = userRepository.users.Where(x => x.IdUser == 5).First(),
                Reporter = userRepository.users.Where(x => x.IdUser == 3).First(),
                Comments = CommentRepository.comments.Where(x=> x.IdTicket == "GAR-15").ToList() 
            },
            new Ticket
            {
                idTicket = "GAR-6",
                Title = "Understand Quick start guide for gerber API",
                Type = typeTicketRepository.typeTickets[1],
                Priority = priorityRepository.priorities[1],
                Labels = "None",
                Sprint = new Sprint
                {
                    IdSprint=1,
                    Description ="Sprint 1 Back-end planning",
                    EndDate = new DateTime(2015,02,07)
                },
                Status = statusRepository.statuses[5],
                Resolution = resolutionRepository.resolutions[0],
                DateCreated = new DateTime(2015,01,19),
                DateUpdated = new DateTime(2015,01,19),
                Description = "fghjhjkjr",
                Assignee = userRepository.users.Where(x => x.IdUser == 2).First(),
                Reporter = userRepository.users.Where(x => x.IdUser == 3).First(),
                Comments = CommentRepository.comments.Where(x=> x.IdTicket == "GAR-15").ToList() 
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

        public Ticket Get(string id)
        {
            var matches = tickets.Where(x => x.idTicket == id);
            return matches.Count() > 0 ? matches.First() : null;
        }

        public bool Update(Ticket item)
        {
            Ticket ticket = Get(item.idTicket);
            if (ticket != null && item.Status.Id != 0)
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
                //ticket.Comments = item.Comments;
                return true;
            }
            else if (ticket != null)
            {
                Status status = statusRepository.GetStatus(item.Status.Title);
                ticket.Status = statusRepository.statuses.Where(x => x.Id == status.Id).First();
                return true;
            }
            else { return false; }
        }
    }
}
