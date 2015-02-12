using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BugTracker.Entities
{
    public class Ticket
    {
        public string idTicket { get; set; }
        public string Title { get; set; }
        public TypeTicket Type { get; set; }
        public Priority Priority { get; set; }
        public string Labels { get; set; }
        public Sprint Sprint { get; set; }
        public Status Status { get; set; }
        public Resolution  Resolution { get; set; }
        public string Description { get; set; }
        public People Assignee { get; set; }
        public People Reporter { get; set; }
        public int Votes { get; set; }
        public List<People> Watchers { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public List<Comment> Comments { get; set; }        
    }
}
