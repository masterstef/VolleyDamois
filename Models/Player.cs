using System;
using System.ComponentModel.DataAnnotations;

namespace VolleyDamois.Models
{
    public class Player
    {
        public Player() { }

        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^(([A-Z]|[a-z]| ){1,30})$")]
        public string Name { get; set; }
        
        [Required]
        [RegularExpression(@"^(([A-Z]|[a-z]| ){1,30})$")]
        public string LastName { get; set; }
        
        [Required]
        public int NumMember { get; set; }
        
        [Required]
        [RegularExpression(@"^(([A-Z]|[a-z]|\d| ){1,30})$")]
        public string Adress { get; set; }
        
        
        public Sex Sex { get; set; }

        public string Email { get; set; }

        [RegularExpression(@"^((\d| ){1,30})$")]
        public string TelNumber { get; set; }
        }
}