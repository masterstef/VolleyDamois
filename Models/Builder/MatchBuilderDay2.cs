using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyDamois.Models.Builder
{
    public class MatchBuilderDay2 : MatchBuilder
    {
        public MatchBuilderDay2(Level level) : base(level) { }
        public List<Match> createMatchesforDay2(List<Dictionary<Team, int[]>> poules,
            List<Field> terrains,
            State state)
        {
            Dictionary<Category, List<Team[]>> matchDay2 = new Dictionary<Category, List<Team[]>>();
            foreach (Category c in Enum.GetValues(typeof(Category)))
            {
                matchDay2.Add(c, new List<Team[]>());
            }

            List<Team> ArbitreReferee = new List<Team>();
            poules.ForEach(p =>
            {
                List<Team> teams = p.Keys.ToList();
                Team[] victoryTeam = new Team[4];
                victoryTeam[0] = teams[0];
                victoryTeam[1] = teams[1];
                victoryTeam[2] = teams[2];
                victoryTeam[3] = teams[3];
                for (int i = 4; i < teams.Count; i++)
                {
                    ArbitreReferee.Add(teams[i]);
                }

                matchDay2[teams[0].Category.Category].Add(victoryTeam);

            });
            return createSeize(matchDay2, terrains, state, ArbitreReferee);
        }

        private List<Match> createSeize(
                Dictionary<Category, List<Team[]>> teamsToSplit,
                List<Field> terrains,
                State state,
                List<Team> referees)
            {
                List<Match> matches = new List<Match>();
                foreach (Category c in Enum.GetValues(typeof(Category)))
                {
                    base.InitData(terrains);
                    List<Field> terrainsForCategory = terrains.Where(t => t.FieldCategory.Category == c).ToList();
                    for (int i = 0; i < teamsToSplit[c].Count / 2; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            matches.Add(
                                new Match(teamsToSplit[c][i][j],
                                    teamsToSplit[c]
                                        [teamsToSplit[c].Count - 1 - i]
                                        [teamsToSplit[c][teamsToSplit[c].Count - 1 - i].Length - 1 - j],
                                    terrains[GetIndexTerrain()],
                                    state,
                                    new DateTime(2020, 1, 2, hour, minute, 0), base.level)
                            );
                        }
                    }
                }

                int index = 0;
                foreach (var match in matches)
                {
                    match.Arbitre = referees[index];
                    index++;
                }
                return matches;
            }

    }
}
