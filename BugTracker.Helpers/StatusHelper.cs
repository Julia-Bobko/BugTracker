using BugTracker.Helpers.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Helpers
{
    public class StatusHelper
    {
        public List<string> GetStatus()
        {
            List<string> status = new List<string>();
            var array = Enum.GetValues(typeof(Status));
            foreach (var item in array)
            {
                status.Add(item.ToString().Replace('_',' '));
            }
            return status;
        }
    }
}
