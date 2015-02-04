using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
   public class Sprint
    {
        public int IdSprint { get; set; }
        public string Description { get; set; }
        public DateTime EndDate { get; set; }
    }
}
