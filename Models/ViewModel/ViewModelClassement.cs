using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyDamois.Models.ViewModel
{
    public class ViewModelClassement
    {
        public List<Dictionary<Team, int[]>> classementDay1 { get; set; }
        public Dictionary<LevelMatch, List<Team>> classementDay2 { get; set; }
    }
}
