using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GapShoes.Models
{
    public class GapShoesContext : DbContext
    {
        public GapShoesContext() : base("DefaultConnection") { }

        public DbSet<Stores> Stores { get; set; }
        public DbSet<Articles> Articles { get; set; }
    }
}