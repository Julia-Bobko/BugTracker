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
    public class TypeTicketController : ApiController
    {
        TypeTicketRepository repo;

        TypeTicketController()
        {
            repo = new TypeTicketRepository();
        }

        public List<TypeTicket> GetTypeTicket()
        {
            return repo.GetTypeTicket();
        }
    }
}
