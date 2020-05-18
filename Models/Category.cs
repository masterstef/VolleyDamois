using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyDamois.Models
{
   
    public class Categories{
        public int Id { get; set; }
        [Required]
        public Category Category { get; set; }
    }
    public enum Category
    {
        Nationale,
        Provinciale,
        Loisir
    }
    public class Sex{
        public int Id { get; set; }
        [Required]
        public Sexe Sexe { get; set; }
    }
    public enum Sexe
    {
        homme,
        femme
    }
    public enum Statut
    {
        planned,
        inProgress,
        done,
    }

}
