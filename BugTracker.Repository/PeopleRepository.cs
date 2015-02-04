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
            Image = ""
        },
        new People 
        {
            IdPeople = 2,
            FullName ="Yarov",
            Image=""
        },
        new People 
        {
            IdPeople=3,
            FullName = "Сhernov",
            Image =""
        },
        new People 
        {
            IdPeople = 4,
            FullName = "Belyaeva",
            Image=""
        },
        new People
        {
            IdPeople = 5,
            FullName ="Schukin",
            Image =""
        }
       };
         
    }
}
