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
    public class StatusController : ApiController
    {
        StatusRepository repo;
        StatusController() {
            repo = new StatusRepository();
        }
        public List<Status> GetStatus()
        {
            return repo.GetStatuses();
        }
    }
}
