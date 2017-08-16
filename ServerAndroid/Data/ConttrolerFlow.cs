using Microsoft.EntityFrameworkCore;
using ServerAndroid.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerAndroid.Data
{
    public class ConttrolerFlow : DbContext
    { public ConttrolerFlow (DbContextOptions<ConttrolerFlow> options) : base(options)
            {
        }

        public DbSet<Flower> Flowers { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flower>().ToTable("Flower");
         

        }
    }

}

