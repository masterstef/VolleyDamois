using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyDamois.Models
{
    public class Match
    {
        public Match(Team team1,Team team2,DateTime startTime) {
            this.Team1 = team1;
            this.Team2 = team2;
            this.StartTime = startTime;
            this.statut = Statut.planned;
        }
        public Team Team1 { get; }
        public Team Team2 { get; }
        public int[] Team1Set { get; set; }
        public int[] Team2Set { get; set; }
        public Statut statut { get; set; }
        public DateTime StartTime { get; }

    }
}
