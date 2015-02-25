using BugTracker.Entities;
using BugTracker.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BugTracker.Web.Controllers
{
    public class CommentController : ApiController
    {
        CommentRepository repo;

        CommentController() {
            repo = new CommentRepository();
        }
        public void PostComment(Comment comment)
        {
            repo.AddComment(comment);
        }

        public List<Comment> GetComments()
        {
            return repo.GetComments();
        }
    }
}
