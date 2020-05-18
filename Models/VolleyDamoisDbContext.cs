using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VolleyDamois.Models
{
    public class VolleyDamoisDbContext : DbContext
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
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Team> Team { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Sex> Sex { get; set; }
        public DbSet<Categories> Categories { get; set; }


    }
}
