using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Repository
{
    public class CommentRepository
    {
       public List<Comment> comments = new List<Comment>
       {
           new Comment
           {
               IdTicket =1,
               Comments = "qweetgkd"
           },
           new Comment
           {
               IdTicket =1,
               Comments ="fff"
            }
       };
    }
}
