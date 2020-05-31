using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyDamois.Models.Builder
{
    public class MatchBuilder
    {
        internal int indexTerrain;
        internal int hour;
        internal int minute;

        internal List<Field> terrains;
        internal Level level;
        internal List<Match> confrontations;

        public MatchBuilder(Level level)
        {
            this.level = level;
        }

        internal void InitData(List<Field> terrains)
        {
            hour = 9;
            minute = 00;
            indexTerrain = 0;
            this.terrains = terrains;
        }


        internal int GetIndexTerrain()
        {
            if (indexTerrain == terrains.Count)
            {
                indexTerrain = 0;
                SetStarTime();
            }

            return indexTerrain;
        }
        internal void SetStarTime()
        {
            minute += 30;
            if (minute == 60)
            {
                minute = 0;
            }
            if (minute == 30 && hour == 12)
            {
                hour = 13;
            }
            else if (minute == 0)
            {
                hour++;
            }
        }

    }
}
