using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using shared.models.configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared.models
{
    public  class DartDbContext : DbContext
    {
        #region Properties
        #region Tables
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Match> Matches { get; set; }
        #endregion
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=DartsDb")
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
                .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApplicationsUserConfiguration());
            modelBuilder.ApplyConfiguration(new MatchConfiguration());
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            // Pre-convention model configuration goes here
            configurationBuilder.Properties<string>().HaveMaxLength(50);    
        }

    }
}
