using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace VolleyDamois.Models
{
    public class VolleyDamoisDbContext : IdentityDbContext
    {
        public VolleyDamoisDbContext(DbContextOptions<VolleyDamoisDbContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasData(new {Id = 1, Category = Category.Nationale});
            modelBuilder.Entity<Categories>().HasData(new {Id = 2, Category = Category.Provinciale });
            modelBuilder.Entity<Categories>().HasData(new {Id = 3, Category = Category.Loisir });

            modelBuilder.Entity<Sex>().HasData(new { Id = 1, Sexe = Sexe.homme });
            modelBuilder.Entity<Sex>().HasData(new { Id = 2, Sexe = Sexe.femme });
            
              CreateStates(modelBuilder);
              CreateFields(modelBuilder);
              CreateLevels(modelBuilder);


            //TestData
            int nbPlayer = 1;
            for (int i = 1; i <= 12; i++)
            {
                modelBuilder.Entity<Team>().HasData(new { Id = i, CategoryId = 1, TeamName = "Equipe"+i });
                modelBuilder.Entity<Player>().HasData(new { Id = nbPlayer++, Name = Char.ToString((char)('A' + nbPlayer)), LastName = Char.ToString((char)('A' + nbPlayer + 1)), NumMember = nbPlayer, Adress = "Rue", Email = "a@hatmail.com", TelNumber = "03430 34", TeamId = i, SexId = 1 });
                modelBuilder.Entity<Player>().HasData(new { Id = nbPlayer++, Name = Char.ToString((char)('A' + nbPlayer)), LastName = Char.ToString((char)('A' + nbPlayer + 1)), NumMember = nbPlayer, Adress = "Rue", TeamId = i, SexId = 1 });
                modelBuilder.Entity<Player>().HasData(new { Id = nbPlayer++, Name = Char.ToString((char)('A' + nbPlayer)), LastName = Char.ToString((char)('A' + nbPlayer + 1)), NumMember = nbPlayer, Adress = "Rue", TeamId = i, SexId = 2 });
            }
            base.OnModelCreating(modelBuilder);
        }

        private static void CreateStates(ModelBuilder modelBuilder)
        {
            int id = 1;
            foreach (StateMatch state in Enum.GetValues(typeof(StateMatch)))
            {
                modelBuilder.Entity<State>().HasData(new {Id = id, StateMatch = state});
                id++;
            }
        }

        private static void CreateLevels(ModelBuilder modelBuilder)
        {
            int id = 1;
            foreach ( LevelMatch l in Enum.GetValues(typeof(LevelMatch)))
            {
                modelBuilder.Entity<Level>().HasData(new { Id = id++, LevelConfrotation = l });
            }
        }

        private static void CreateFields(ModelBuilder modelBuilder)
        {
            int currentCategoryId;
            for (int i = 1; i <= 12; i++)
            {
                if (i <= 4)
                {
                    currentCategoryId = 1;
                }
                else if (i > 4 && i < 9)
                {
                    currentCategoryId = 2;
                }
                else
                {
                    currentCategoryId = 3;
                }

                modelBuilder.Entity<Field>().HasData(new {Id = i, FieldCategoryId = currentCategoryId});
            }
        }

        public DbSet<Team> Team { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Sex> Sex { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Poule> Poules { get; set; }
        public DbSet<Level> Level { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Field> Field { get; set; }
    }
}
