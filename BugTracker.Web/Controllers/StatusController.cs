using BugTracker.Helpers;
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
        private StatusHelper statusHelper;
        public StatusController()
        {
            statusHelper = new StatusHelper();
        }
        public List<string> GetStatus()
        {
            return statusHelper.GetStatus();
        }
    }
}
