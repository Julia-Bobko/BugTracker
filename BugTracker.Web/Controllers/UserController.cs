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
    public class UserController : ApiController
    {
        UserRepository repo;

        UserController()
        {
            repo =  new UserRepository();
        }

        public List<User> GetUsers()
        {
           return repo.GetUsers();
        }
    }
}
