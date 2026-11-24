using Gym.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection;

namespace Gym.context
{
    public class GymDbcontext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Gym;Trusted_Connection=true;TrustServerCertificate=true");
        }
        #region
        protected override void OnModelCreating(ModelBuilder modelBuilder) //Fluent API
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
        #endregion


        #region Dbset 

        public DbSet<Trainer> Trainers { get; set; }

        public DbSet <Member> Members { get; set; }

        public DbSet  <MemberShip> MemberShips { get; set; }

        public DbSet <Plan> Plans { get; set; } 

        public DbSet <Session> Sessions { get; set; }















        #endregion
    }
}
