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
        static public List<Comment> comments = new List<Comment>
       {
           new Comment
           {
               IdTicket = "GAR-4",
               Comments = "qweetgkd"
           },
           new Comment
           {
               IdTicket = "GAR-4",
               Comments = "asercv kj vef "
           },
            new Comment
           {
               IdTicket = "GAR-3",
               Comments = "There are no comments yet on this issue."
            },
             new Comment
           {
               IdTicket = "GAR-1",
               Comments = "There are no comments yet on this issue."
            },
              new Comment
           {
               IdTicket = "GAR-2",
               Comments = "begth ghjki asdec "
            }
       };


        public void AddComment(Comment comment)
        {
            comments.Add(comment);
            var ticket = TicketRepository.getRepository().GetAll().Where(x => x.idTicket == comment.IdTicket).First();
            ticket.Comments = comments.Where(x => x.IdTicket == ticket.idTicket).ToList();
        }

        public List<Comment> GetComments()
        {
            return comments;
        }
    }
}
