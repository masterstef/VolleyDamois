using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using VolleyDamois.Models.Builder;

namespace VolleyDamois.Models
{
    public class MatchBuilderDay1 : MatchBuilder
    {
        public MatchBuilderDay1(Level level) : base(level) { }

        public List<Match> createMatchesforPoule(IList<Poule> poules, List<Field> terrains,State state)
        {
            List<Match>matchsPeerCategory = new List<Match>();
            foreach (Category currentCategory in Enum.GetValues(typeof(Category)))
            {
                matchsPeerCategory.AddRange(
                createMatchesforCategoryPoule(
                    poules.Where(p => p.Teams[0].Category.Category == currentCategory).ToList(),
                    terrains.Where(t => t.FieldCategory.Category == currentCategory).ToList(),
                    state));
            }
            return matchsPeerCategory;
        }

        public List<Match> createMatchesforCategoryPoule(List<Poule> poules, List<Field> terrains,State state)
        {
            List<Match> confrontationsPoules = new List<Match>();
            InitData(terrains);
            foreach (var poule in poules) {
                List<Team> TeamsReferee = poules.Where( p => p.id != poule.id).SelectMany( p => p.Teams).ToList();
                List<Match>confrontations = AllConfrontationForAPoule(poule,base.level, state);
                int TeamRefereeIndex = 0;
                confrontations.ForEach( m => {
                    if (TeamRefereeIndex == TeamsReferee.Count) TeamRefereeIndex = 0;
                    m.Arbitre = TeamsReferee[TeamRefereeIndex];
                    TeamRefereeIndex++;
                });
                confrontationsPoules.AddRange(confrontations);
            }

            return confrontationsPoules;
        }

        private List<Match> AllConfrontationForAPoule(Poule poule, Level l,State state)
        {
            List<Match> confrotations = new List<Match>();
            IList<Team>teams = poule.Teams;
            for (int i = 1; i < teams.Count; i++)
            {
                if (teams.Count % 2 != 0) {
                    ShiftRight(teams);
                    confrotations.AddRange(GetMatchesOdd(teams,l,state));
                }
                else{
                    ShiftRight(teams);
                    SwitchFirst(teams);
                    confrotations.AddRange(GetMatchesPeer(teams,l,state));
                }
            }

            return confrotations;
        }

        

        private List<Match> GetMatchesOdd(IList<Team> teams,Level levelPoule,State state)
        {
            List<Match> Matches = new List<Match>();
            for (int i = 0; i < teams.Count / 2; i++) {
                Match matchToAdd = new Match(
                    teams[i],
                    teams[teams.Count - 2 - i],
                    base.terrains[GetIndexTerrain()],
                    state,
                    new DateTime(2020, 01, 01, base.hour, base.minute, 0),
                    levelPoule
                );
                Matches.Add(matchToAdd);
            }

            return Matches;
        }
        private List<Match> GetMatchesPeer(IList<Team> teams, Level levelPoule,State state)
        {
            List<Match> Matches = new List<Match>();
            for (int i = 0; i < teams.Count / 2; i++)
            {
                Match matchToAdd = new Match(
                    teams[i],
                    teams[teams.Count - 1 - i],
                    terrains[GetIndexTerrain()],
                    state,
                    new DateTime(2020, 01, 01, hour, minute, 0),
                    levelPoule
                );
                indexTerrain++;
                Matches.Add(matchToAdd);
            }

            return Matches;

        }

        private void ShiftRight(IList<Team> teams)
        {
            Team tempLast = teams[teams.Count-1];
            Team temp1 = teams[0];
            for (int i = 1; i < teams.Count; i++)
            {
                Team temp2 = teams[i];
                teams[i] =  temp1;
                temp1 = temp2;
            }

            teams[0] = tempLast;
        }

        private void SwitchFirst(IList<Team> teams)
        {
            Team temp = teams[1];
            teams[1] = teams[0];
            teams[0] = temp;
        }
    }
}
