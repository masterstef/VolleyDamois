using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyDamois.Models
{
    public class Match
    {
        public Match() { }

        public Match(Team team1,Team team2, Field t, State state,DateTime startTime,Level l) {
            this.Team1 = team1;
            this.Team2 = team2;
            this.StartTime = startTime;
            this.Terrain = t;
            this.level = l;
            this.State = state;
        }

        public Field Terrain { get; set; }
        public int Id { get; set; }
        public Level level { get; set; }
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Team Arbitre { get; set; }
        public int Team1Set1 { get; set; }
        public int Team1Set2 { get; set; }
        public int Team2Set1 { get; set; }
        public int Team2Set2 { get; set; }
        public State State { get; set; }
        public DateTime StartTime { get; set; }
    }
}
