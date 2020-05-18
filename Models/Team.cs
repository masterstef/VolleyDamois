using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VolleyDamois.Validation;

namespace VolleyDamois.Models
{
    [Team]
    public class Team
    {
        public Team() { }

        public int Id { get; set; }

        
        public Categories Category { get; set; }

        [Required]
        public List<Player> Players { get; set; }

        [Required]
        [RegularExpression(@"^([A-Z]|[a-z]|\d| ){1,30}$")]
        public string TeamName { get; set; }

    }
}
