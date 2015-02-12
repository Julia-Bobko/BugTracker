using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Repository
{
   public class PriorityRepository
    {       
      public List<Priority> priorities = new List<Priority>()
       {
           new Priority
           {
               Id=1,
               Title ="Major",
               Image="app/img/major.jpg"
           },
           new Priority
           {
               Id=2,
               Title ="Minor",
               Image="app/img/minor.jpg"
           }         
       };
    }
}
