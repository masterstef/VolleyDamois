using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyDamois.Models
{
    public class Poule
    {
        public int id { get; set; }
        public String Name { get; set; }
        public IList<Team> Teams { get; set; }
    }

}   
    
