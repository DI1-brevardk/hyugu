using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyugu.Models
{
    public class HeroContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Katogan-PC;Initial Catalog=Z_TEST;Integrated Security=True;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Quirk> Quriks { get; set; }
        public DbSet<School> Schools { get; set; }

    }
}