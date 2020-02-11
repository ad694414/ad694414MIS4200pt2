using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ad694414MIS4200.Models.DAl;

namespace ad694414MIS4200.Models.DAl
{
    public class MIS4200Context : DbContext
    {

            public MIS4200Context() : base("name=DefaultConnection")
            {
            //setinitializer
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, ad694414MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));

            }

            public DbSet<Doctor> Doctor { get; set; }
            public DbSet<Appointment> Appointment { get; set; }
            public DbSet<Patient> Patient { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
