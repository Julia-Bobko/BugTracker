using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Repository
{
    public class StatusRepository
    {
        public List<Status> statuses = new List<Status>()
        { 
            new Status
            {
                Id =1,
                Title ="To Do"
            },
            new Status
            {
                Id =2,
                Title ="Resolved"
            },
            new Status
            {
                Id =3,
                Title ="In Progress"
            },
             new Status
            {
                Id =4,
                Title ="Ready for testing"
            },
             new Status
            {
                Id =5,
                Title ="Test in progress"
            },
            new Status
            {
                Id =6,
                Title ="Done"
            }
        };
        public List<Status> GetStatuses()
        {
            return statuses;
        }
    }
}
