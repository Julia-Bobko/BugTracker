using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Repository
{
    public class PeopleRepository
    {
        public List<People> people = new List<People>{
        new People
        {
            IdPeople =1,
            FullName ="Shitov",
            Image = "app/img/1.png",
            EmailAddress="shitov@mail.ru",
            Password="111"
        },
        new People 
        {
            IdPeople = 2,
            FullName ="Yarov",
            Image = "app/img/2.png",
            EmailAddress="yarov@mail.ru",
            Password="yarov"
        },
        new People 
        {
            IdPeople=3,
            FullName = "Сhernov",
            Image = "app/img/3.png",
            EmailAddress="Сhernov@mail.ru",
            Password="chernov"
        },
        new People 
        {
            IdPeople = 4,
            FullName = "Belyaeva",
            Image = "app/img/4.png",
            EmailAddress="belyaeva@mail.ru",
            Password="belyaeva"       
        },
        new People
        {
            IdPeople = 5,
            FullName ="Schukin",
            Image = "app/img/5.png",
            EmailAddress="schukin@mail.ru",
            Password="schukin"
        }
       };

        public bool IsUser(string fullname)
        {
            var matches = people.Where(x => x.FullName == fullname);
            return matches.Count() > 0 ? true : false;
        }

        public void CreateAccount(People user)
        {
           if (!IsUser(user.FullName))
            {
                user.IdPeople = people.Count + 1;
                people.Add(user);               
            }           
        }

        public bool LogIn(string fullName, string password) 
        {
            var matches = people.Where(x => x.FullName == fullName && x.Password==password);
            return matches.Count() > 0 ? true : false;          
        }
    }
}
