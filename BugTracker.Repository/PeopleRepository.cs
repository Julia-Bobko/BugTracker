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
            Image = "app/img/1.jpg"
        },
        new People 
        {
            IdPeople = 2,
            FullName ="Yarov",
             Image = "app/img/2.jpg"
        },
        new People 
        {
            IdPeople=3,
            FullName = "Сhernov",
             Image = "app/img/3.jpg"
        },
        new People 
        {
            IdPeople = 4,
            FullName = "Belyaeva",
             Image = "app/img/4.jpg"
        },
        new People
        {
            IdPeople = 5,
            FullName ="Schukin",
            Image = "app/img/5.jpg"
        }
       };
         
    }
}
