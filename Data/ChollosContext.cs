using MvcChollos2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcChollos2.Data
{
    public class ChollosContext: DbContext
    {
        public ChollosContext() : base("name=cadenachollos") { }
        public DbSet<Chollo> Chollos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ChollosContext>(null);
        }
    }
}