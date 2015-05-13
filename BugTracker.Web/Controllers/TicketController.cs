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
        private TicketRepository repo;

        TicketController()
        {
            repo = new TicketRepository();
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return repo.GetAll();
        }

        public Ticket GetTicket(string id)
        {
            return repo.Get(id);
        }

        public bool PutTicket(Ticket item)
        {
            return repo.Update(item);
        }
    }
}
