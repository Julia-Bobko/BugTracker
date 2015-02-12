using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Repository
{
    public class ResolutionRepository
    {
       public  List<Resolution> resolutions = new List<Resolution>()
        {
            new Resolution
            {
                Id=1,
                Title = "Unresolved"
            },
            new Resolution
            {
                Id=2,
                Title="Fixed"
            }
        };
    }
}
