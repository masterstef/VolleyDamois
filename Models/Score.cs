namespace VolleyDamois.Models
{
    public class Score
    {
        public Score(int points,int to,int against,Team team) {
            this.Points = points;
            this.To = to;
            this.Against = against;
            this.Team = team;
        }

        public int Points { get; }
        public int To { get; }
        public int Against { get; }
        public Team Team { get; }
    }
}