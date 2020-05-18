using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyDamois.Models
{
    public class Poule
    {
        List<Score> classement;

        Poule(List<Score> classement)
        {
            this.classement = classement;
        }

        public void OrderResult()
        {
            foreach (Score score in classement)
            {
                int currentIndex = classement.IndexOf(score);
                while (currentIndex < classement.Count-1 && score.Points >= classement[currentIndex + 1].Points)
                {
                    switchScore(classement, currentIndex, score);
                }
            }
            foreach (Score score in classement)
            {
                int currentIndex = classement.IndexOf(score);
                while (score.To - score.Against > classement[currentIndex + 1].To - classement[currentIndex + 1].Against
                       && score.Points == classement[currentIndex + 1].Points)
                {
                    switchScore(classement, currentIndex, score);
                }
            }
        }

        private void switchScore(List<Score> classement, int currentIndex, Score score)
        {
            Score tempScore = classement[currentIndex + 1];
            classement[currentIndex + 1] = score;
            classement[currentIndex] = tempScore;
            currentIndex = currentIndex + 1;
        }
    }
}
