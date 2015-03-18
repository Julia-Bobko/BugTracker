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
    public class ResolutionController : ApiController
    {
        ResolutionRepository repo;

        ResolutionController()
        {
            repo = new ResolutionRepository();
        }

        public List<Resolution> GetResolution()
        {
            return repo.GetResolution();
        }
    }
}
