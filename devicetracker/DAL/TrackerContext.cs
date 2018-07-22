using devicetracker.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace devicetracker.DAL
{
    public class TrackerContext : DbContext
    {
        public TrackerContext() : base("TrackerContext")
        {
            
        }

        public DbSet<Device> Devices { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}