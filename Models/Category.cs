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

    public class Level
    {
        public int Id { get; set; }
        public LevelMatch LevelConfrotation { get; set; }
    }

    public class State
    {
        public int Id { get; set; }
        public StateMatch StateMatch { get; set; }
    }

    public class Field
    {
        public int Id { get; set; }
        public Categories FieldCategory { get; set; }
    }
    public enum Sexe
    {
        homme,
        femme
    }
    public enum StateMatch
    {
        planned,
        inProgress,
        done,
    }
    public enum LevelMatch
    {
        Poule,
        Seizième,
        Huitième,
        Quart,
        Demi,
        Final
    }

}
