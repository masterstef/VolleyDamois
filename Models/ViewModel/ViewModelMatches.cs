using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyDamois.Models
{
    public class ViewModelMatches
    {
        public Dictionary<DateTime, List<Match>> rounds { get; set; }

        public void FormatMatches (List<Match>matches)
        {
            rounds = matches.GroupBy(m => m.StartTime)
                    .OrderBy(m => m.Key)
                    .ToDictionary(g => g.Key,
                        g => g.OrderBy(matches => matches.Terrain.Id).ToList());
            
        }
    }
}
