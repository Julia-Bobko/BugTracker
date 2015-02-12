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
        List<Ticket> tickets;
        PeopleRepository peopleRepository;
        CommentRepository commentRepository;
        StatusRepository statusRepository;
        ResolutionRepository resolutionRepository;
        TypeTicketRepository typeTicketRepository;
        PriorityRepository priorityRepository;
  
        TicketRepository()
        {
            peopleRepository = new PeopleRepository();
            commentRepository = new CommentRepository();
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
                Description = "fghjhjkjr",
                Assignee = peopleRepository.people.Where(x => x.IdPeople == 1).First(),
                Reporter = peopleRepository.people.Where(x => x.IdPeople == 3).First(),
                Comments = commentRepository.comments.Where(x=> x.IdTicket == 1).ToList()                
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
                Resolution =resolutionRepository.resolutions[1],
                DateCreated = new DateTime(2015,01,19),
                DateUpdated = new DateTime(2015,01,19),
                Description = "rtjn mikk vfbg tarket nj",
                Assignee = peopleRepository.people.Where(x => x.IdPeople == 2).First(),
                Reporter = peopleRepository.people.Where(x => x.IdPeople == 1).First(),
                Comments = commentRepository.comments.Where(x=> x.IdTicket == 2).ToList() 
            },
             new Ticket
            {
                idTicket = "GAR-2",
                Title = "hjhjlklkm",
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
                Resolution = resolutionRepository.resolutions[1],
                DateCreated = new DateTime(2015,01,19),
                DateUpdated = new DateTime(2015,01,19),
                Description = "fghjhjkjr",
                Assignee = peopleRepository.people.Where(x => x.IdPeople == 4).First(),
                Reporter = peopleRepository.people.Where(x => x.IdPeople == 5).First(),
                Comments = commentRepository.comments.Where(x=> x.IdTicket == 3).ToList() 
            },
            new Ticket
            {
                idTicket = "GAR-15",
                Title = "jkkm.,,",
                Type = typeTicketRepository.typeTickets[0],
                Priority = priorityRepository.priorities[0],
                Labels = "None",
                Sprint = new Sprint
                {
                    IdSprint=1,
                    Description ="Sprint 1 Back-end planning",
                    EndDate = new DateTime(2015,02,07)
                },
                Status = statusRepository.statuses[3],
                Resolution = resolutionRepository.resolutions[0],
                DateCreated = new DateTime(2015,01,19),
                DateUpdated = new DateTime(2015,01,19),
                Description = "fghjhjkjr",
                Assignee = peopleRepository.people.Where(x => x.IdPeople == 4).First(),
                Reporter = peopleRepository.people.Where(x => x.IdPeople == 1).First(),
                Comments = commentRepository.comments.Where(x=> x.IdTicket == 3).ToList() 
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
