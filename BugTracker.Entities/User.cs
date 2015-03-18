using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    public class User
    {
        public int IdUser { get; set; }
        public string FullName { get; set; }
        public string Image { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}
