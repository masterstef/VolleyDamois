using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyDamois.Models
{
    public class ClassementDay2
    {
        public ClassementDay2(List<Match>matches) {
            AllMatches = matches;
        }

        public List<Match> AllMatches;
        public Dictionary<LevelMatch, List<Team>> MakeClassement()
        {
            Dictionary<LevelMatch,List<Team>> winnerLevelList = new Dictionary<LevelMatch,List<Team>>();
            foreach (LevelMatch level in Enum.GetValues(typeof(LevelMatch)))
            {
                List<Team> winnerList = new List<Team>();
                var MatchesForCurrentLevel = AllMatches.Where(m => m.level.LevelConfrotation == level).ToList();
                MatchesForCurrentLevel.ForEach(m =>
                {
                    if (m.Team1Set1 + m.Team1Set2 > m.Team2Set1 + m.Team2Set2) {
                        winnerList.Add(m.Team1);
                    }
                    else if (m.Team1Set1 + m.Team1Set2 == 0 && m.Team2Set1 + m.Team2Set2 == 0) {

                    }else {
                        winnerList.Add(m.Team2);
                    }
                });
                winnerLevelList.Add(level,winnerList);
            }

            return winnerLevelList;
        }
    }
}
