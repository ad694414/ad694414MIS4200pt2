using System;
using System.Collections.Generic;
using System.Data.Entity;
using ad694414MIS4200.Models;
using System.Linq;
using System.Web;

namespace ad694414MIS4200.DAL
{
    public class MIS4200 : DbContext
    {
        public MIS4200() : base("name=DefaultConnection")
        {

        }

        public DbSet<orders> Orders { get; set; }
        public DbSet<customer> Customer { get; set; }
    }
}