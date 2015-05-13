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
    public class ResolutionRepository
    {
        private string ConnectionString = "Data Source=juli;Initial Catalog=bagTrackerDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

       //public  List<Resolution> resolutions = new List<Resolution>()
       // {
       //     new Resolution
       //     {
       //         IdResolution=1,
       //         Title = "Unresolved"
       //     },
       //     new Resolution
       //     {
       //         IdResolution=2,
       //         Title="Fixed"
       //     }
       // };

       public List<Resolution> GetResolution()
       {
           var sql = String.Format(@"SELECT * FROM resolution");
           using (var conn = new SqlConnection(ConnectionString))
           {
               var listResolution = conn.Query<Resolution>(sql).ToList();
               return listResolution;
           }
           //return resolutions;
       }
    }
}
