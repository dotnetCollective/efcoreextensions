using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EfCore.Extensions.Tests.Models
{
    internal class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<NullSemanticsEntity> Entities { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<NullSemanticsEntity>();
        }
    }
}
