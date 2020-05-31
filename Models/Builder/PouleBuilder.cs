using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyDamois.Models
{
    public class PouleBuilder
    {
        IList<Poule> PoulesForAllCategories = new List<Poule>();
        private void createPoulesForCategory(IList<Team> teams, Category category)
        {
            List<Poule> poules = new List<Poule>();
            List<Team> teamForCategory = teams.Where(e => e.Category.Category == category).ToList();

            int numberOfPlayers = teamForCategory.Count;
            int bestChoise = 1;
            int restToSplit = Int32.MaxValue;
            int rollCount = 0;
            int nbPoule;
           

            for (int i = 5; i < 9; i++)
            {
                if (numberOfPlayers % i < restToSplit)
                {
                    restToSplit = numberOfPlayers % i;
                    bestChoise = i;
                }
            }

            nbPoule = numberOfPlayers / bestChoise;
            
            for (int i = 0; i < nbPoule; i++)
            {
                IList<Team> TeamsPouleList = new List<Team>();
                Poule p = new Poule();
                p.Name = "Poule " + (i+1) ;
                for (int j = 0; j < bestChoise; j++)
                {
                    TeamsPouleList.Add(teams[j + rollCount]);
                    if (restToSplit > 0)
                    {
                        TeamsPouleList.Add(teams[numberOfPlayers - restToSplit]);
                        restToSplit--;
                    }
                }

                rollCount += bestChoise;
                p.Teams = TeamsPouleList;
                PoulesForAllCategories.Add(p);
            }
        }


        public IList<Poule> createPoulesForEachCategories(IList<Team> teams)
        {
            
            foreach (Category c in Enum.GetValues(typeof(Category)))
            {
                createPoulesForCategory(teams, c);
            }
            return PoulesForAllCategories;
        }



    }


}
