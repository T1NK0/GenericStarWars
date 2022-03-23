using GenericStarWars.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStarWars.Data
{
    public class StarWarsDbContext : DbContext
    {
        public DbSet<JediMaster> Jedis { get; set; }
        public DbSet<SithMaster> Siths { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("StarWarsDb");
        }
    }
}
