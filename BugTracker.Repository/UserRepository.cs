using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Repository
{
    public class UserRepository
    {
        public List<User> users = new List<User>{
        new User
        {
            IdUser =1,
            FullName ="Shitov",
            Image = "app/img/1.png",
            EmailAddress="shitov@mail.ru",
            Password="111"
        },
        new User 
        {
            IdUser = 2,
            FullName ="Yarov",
            Image = "app/img/2.png",
            EmailAddress="yarov@mail.ru",
            Password="yarov"
        },
        new User 
        {
            IdUser=3,
            FullName = "Сhernov",
            Image = "app/img/3.png",
            EmailAddress="Сhernov@mail.ru",
            Password="chernov"
        },
        new User 
        {
            IdUser = 4,
            FullName = "Belyaeva",
            Image = "app/img/4.png",
            EmailAddress="belyaeva@mail.ru",
            Password="belyaeva"       
        },
        new User
        {
            IdUser = 5,
            FullName ="Schukin",
            Image = "app/img/5.png",
            EmailAddress="schukin@mail.ru",
            Password="schukin"
        }
       };

        public List<User> GetUsers() 
        {
            return users;
        }

        public bool IsUser(string fullname)
        {
            var matches = users.Where(x => x.FullName == fullname);
            return matches.Count() > 0 ? true : false;
        }

        public void CreateAccount(User user)
        {
           if (!IsUser(user.FullName))
            {
                user.IdUser = users.Count + 1;
                users.Add(user);               
            }           
        }

        public bool LogIn(string fullName, string password) 
        {
            var matches = users.Where(x => x.FullName == fullName && x.Password==password);
            return matches.Count() > 0 ? true : false;          
        }
    }
}
