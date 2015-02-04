using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Repository
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> GetAll();
        Ticket Get(int id);
        bool Update(Ticket item);
    }
}
