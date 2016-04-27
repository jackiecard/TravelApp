using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebAppCore.models
{
    public class TripContext : IdentityDbContext<AppUser>
    {

        public DbSet<Trip> Trips { get; set; }
        public DbSet<Stop> Stops { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString =
               Startup.Configuration["Data:DefaultConnection:TripsConnectionString"];
            optionsBuilder.UseSqlServer(connString);
            base.OnConfiguring(optionsBuilder);
            
        }

        public TripContext()
        {
            Database.EnsureCreated();
        }
    }
}
