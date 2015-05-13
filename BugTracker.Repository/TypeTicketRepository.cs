using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace BugTracker.Repository
{
   public  class TypeTicketRepository
    {
       private string ConnectionString = "Data Source=juli;Initial Catalog=bagTrackerDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

      //public  List<TypeTicket> typeTickets = new List<TypeTicket>()
      // {
      //     new TypeTicket 
      //     {
      //         IdType =1,
      //         Title="Task",
      //         ImagePath ="app/img/task.png"
      //     },
      //      new TypeTicket 
      //     {
      //         IdType =2,
      //         Title="Bug",
      //         ImagePath ="app/img/bug.png"
      //     }
      // };

      public List<TypeTicket> GetTypeTicket()
      {
          var sql = String.Format(@"SELECT * FROM types");
          using (var conn = new SqlConnection(ConnectionString))
          {
              var listTypes = conn.Query<TypeTicket>(sql).ToList();
              return listTypes;
          }
         // return typeTickets;
      }
    }
}
