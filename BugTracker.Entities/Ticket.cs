using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BugTracker.Entities
{
    public class Ticket
    {
    //    public string idTicket { get; set; }
    //    public string Title { get; set; }
    //    public TypeTicket Type { get; set; }
    //    public Priority Priority { get; set; }
    //    public string Labels { get; set; }
    //    public Sprint Sprint { get; set; }
    //    public Status Status { get; set; }
    //    public Resolution Resolution { get; set; }
    //    public string Description { get; set; }
    //    public User Assignee { get; set; }
    //    public User Reporter { get; set; }
    //    public int Votes { get; set; }
    //    public List<User> Watchers { get; set; }
    //    public DateTime DateCreated { get; set; }
    //    public DateTime DateUpdated { get; set; }
    //    public List<Comment> Comments { get; set; } 

        public string idTicket { get; set; }
        public string Title { get; set; }
        public TypeTicket Type { get; set; }
        public Priority Priority { get; set; }
        public string Labels { get; set; }
        public Sprint Sprint { get; set; }
        public Status Status { get; set; }
        public Resolution Resolution { get; set; }
        public string Description { get; set; }
        public User Assignee { get; set; }
        public User Reporter { get; set; }
        public int Votes { get; set; }
        public List<User> Watchers { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public List<Comment> Comments { get; set; }     
       
        
       // public int idTicket { get; set; }
       // public string Title { get; set; }
       // public string TitleType { get; set; }
       // public string TitlePriority { get; set; }
       //// public string Labels { get; set; }
       //// public Sprint Sprint { get; set; }
       // public string TitleStatus { get; set; }
       // public string TitleResolution { get; set; }
       // public string Description { get; set; }
       // public string Assignee { get; set; }
       // public string Reporter { get; set; }
       // public int CountWatchers { get; set; }
       // //public string NameProject { get; set; }
       // //public string  ShortNameProject { get; set; }
       // //public int Votes { get; set; }
       // //public List<User> Watchers { get; set; }
       // public DateTime DateCreated { get; set; }
       // public DateTime DateUpdated { get; set; }
      
    }
}
