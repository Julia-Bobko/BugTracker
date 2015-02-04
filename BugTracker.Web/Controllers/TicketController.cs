using BugTracker.Entities;
using BugTracker.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BugTracker.Web.Controllers
{
    public class TicketController : ApiController
    {
        private ITicketRepository repo = TicketRepository.getRepository();

        public IEnumerable<Ticket> GetAllTickets()
        {
            return repo.GetAll();
        }

        public Ticket GetTicket(int id)
        {
            return repo.Get(id);
        }

        public bool PutTicket(Ticket item)
        {
            return repo.Update(item);
        }
    }
}
