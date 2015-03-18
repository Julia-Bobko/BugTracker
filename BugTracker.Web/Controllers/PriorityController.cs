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
    public class PriorityController : ApiController
    {
        PriorityRepository repo;

        PriorityController() 
        {
            repo = new PriorityRepository();
        }

        public List<Priority> GetPriority()
        {
            return repo.GetPriority();
        }
    }
}
