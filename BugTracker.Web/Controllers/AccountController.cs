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
    public class AccountController : ApiController
    {
        UserRepository peopleRepository;
        AccountController()
        {
            peopleRepository = new UserRepository();
        }

        public void PostAccount(User people)
        {
            peopleRepository.CreateAccount(people);
        }

        public bool GetIsUser(string fullName) 
        {
           return peopleRepository.IsUser(fullName);
        }

        public bool Login(string fullName, string password)
        {
            return peopleRepository.LogIn(fullName, password);
        }
    }
}
