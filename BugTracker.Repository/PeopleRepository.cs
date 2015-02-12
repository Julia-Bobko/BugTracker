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
            Image = "app/img/1.jpg",
            EmailAddress="shitov@mail.ru",
            Password="111"
        },
        new People 
        {
            IdPeople = 2,
            FullName ="Yarov",
            Image = "app/img/2.jpg",
            EmailAddress="yarov@mail.ru",
            Password="yarov"
        },
        new People 
        {
            IdPeople=3,
            FullName = "Сhernov",
            Image = "app/img/3.jpg",
            EmailAddress="Сhernov@mail.ru",
            Password="chernov"
        },
        new People 
        {
            IdPeople = 4,
            FullName = "Belyaeva",
            Image = "app/img/4.jpg",
            EmailAddress="belyaeva@mail.ru",
            Password="belyaeva"       
        },
        new People
        {
            IdPeople = 5,
            FullName ="Schukin",
            Image = "app/img/5.jpg",
            EmailAddress="schukin@mail.ru",
            Password="schukin"
        }
       };

    }
}
