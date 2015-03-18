using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Repository
{
   public  class TypeTicketRepository
    {
      public  List<TypeTicket> typeTickets = new List<TypeTicket>()
       {
           new TypeTicket 
           {
               Id =1,
               Title="Task",
               Image ="app/img/task.png"
           },
            new TypeTicket 
           {
               Id =2,
               Title="Bug",
               Image ="app/img/bug.png"
           }
       };

      public List<TypeTicket> GetTypeTicket()
      {
          return typeTickets;
      }
    }
}
