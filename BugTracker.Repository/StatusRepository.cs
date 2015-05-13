using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace BugTracker.Repository
{
    public class StatusRepository
    {
        private string ConnectionString = "Data Source=juli;Initial Catalog=bagTrackerDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

        //public List<Status> statuses = new List<Status>()
        //{ 
        //    new Status
        //    {
        //        IdStatus =1,
        //        TitleStatus ="To Do"
        //    },
        //    new Status
        //    {
        //        IdStatus =2,
        //        TitleStatus ="Blocked"
        //    },
        //    new Status
        //    {
        //        IdStatus =3,
        //        TitleStatus ="In Progress"
        //    },
        //     new Status
        //    {
        //        IdStatus =4,
        //        TitleStatus ="Ready for testing"
        //    },
        //     new Status
        //    {
        //        IdStatus =5,
        //        TitleStatus ="Test in progress"
        //    },
        //    new Status
        //    {
        //        IdStatus =6,
        //        TitleStatus ="Done"
        //    }
        //};
        public List<Status> GetStatuses()
        {
            var sql = String.Format(@"SELECT * FROM statuses");
            using (var conn = new SqlConnection(ConnectionString))
            {
                var statuses = conn.Query<Status>(sql).ToList();
                return statuses;
            }
            //return statuses;
        }

        public Status GetStatus(string title)
        {
            var sql = String.Format(@"SELECT * FROM statuses WHERE title = @title", new {title });
            using (var conn = new SqlConnection(ConnectionString))
            {
                var status = conn.Query<Status>(sql).FirstOrDefault();
                return status;
            }
          //return  GetStatuses().Where(x => x.Title == title).First(); 
        }
    }
}
