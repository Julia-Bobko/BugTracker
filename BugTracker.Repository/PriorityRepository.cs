using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;
using System.Data.SqlClient;

namespace BugTracker.Repository
{
    public class PriorityRepository
    {
        private string ConnectionString = "Data Source=juli;Initial Catalog=bagTrackerDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

       // public List<Priority> priorities = new List<Priority>()
       //{
       //    new Priority
       //    {
       //        IdPriority=1,
       //        TitlePriority ="Major",
       //        ImagePath="app/img/major.png"
       //    },
       //    new Priority
       //    {
       //        IdPriority=2,
       //        TitlePriority ="Minor",
       //        ImagePath="app/img/minor.png"
       //    }         
       //};
        public List<Priority> GetPriority()
        {
            var sql = String.Format(@"SELECT * FROM priorities");
            using (var conn = new SqlConnection(ConnectionString))
            {
                var listPrioriteis = conn.Query<Priority>(sql).ToList();
                return listPrioriteis;
            }
            //return priorities;
        }
    }
}
