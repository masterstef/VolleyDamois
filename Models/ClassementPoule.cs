using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyDamois.Models
{
    public class ClassementPoule
    {
        private List<Poule> AllPoules { get; set; }
        private List<Match> AllMatches { get; set; }
        public ClassementPoule(List<Match> allMatches ,List<Poule> allPoules) {
          this.AllMatches = allMatches;
          this.AllPoules = allPoules;
        }

        public List<Dictionary<Team,int[]>> createClassementPoules() {
            List<Dictionary<Team,int[]>> classement = new List<Dictionary<Team, int[]>>();
            AllPoules.ForEach(p=>classement.Add(createClassementForAPoule(p)));
            return classement;
        }

        public Dictionary<Team,int[]> createClassementForAPoule(Poule p)
        {
            Dictionary<Team,int[]> classementPoule = new Dictionary<Team, int[]>();
            List<Match> tMatcht1 = new List<Match>();
            List<Match> tMatcht2 = new List<Match>();
            int points = 0, to = 0, against =0;
            if(AllMatches.Where(m => m.level.LevelConfrotation == LevelMatch.Poule 
                                     && m.Team1Set1 == 0 
                                     && m.Team1Set1 == 0 
                                     && m.Team2Set2 == 0 
                                     && m.Team2Set2 == 0).Count()==0){
                foreach (Team t in p.Teams)
                {
                   tMatcht1 = AllMatches.Where(m => m.Team1.Id == t.Id).ToList();
                   tMatcht2 = AllMatches.Where(m => m.Team2.Id == t.Id).ToList();

                   points += tMatcht1.Where(m => m.Team1Set1 + m.Team1Set2 > m.Team2Set1 + m.Team2Set2).Count() * 2;
                   points += tMatcht2.Where(m => m.Team1Set1 + m.Team1Set2 < m.Team2Set1 + m.Team2Set2).Count() * 2;

                   tMatcht1.ForEach(m => { to += m.Team1Set1 + m.Team1Set2; against += m.Team2Set1 + m.Team2Set2; });
                   tMatcht2.ForEach(m => { to += m.Team2Set1 + m.Team2Set2; against += m.Team1Set1 + m.Team1Set2; });

                    classementPoule.Add(t,new int[]{points,to,against});
                }

                classementPoule = classementPoule.OrderByDescending(c => c.Value[0])
                    .ThenBy(c => c.Value[1] - c.Value[2]).ToDictionary(
                        c => c.Key,
                        c => c.Value);
                return classementPoule;
            }
            else
            {
                return new Dictionary<Team, int[]>();
            }
        }
    }}
