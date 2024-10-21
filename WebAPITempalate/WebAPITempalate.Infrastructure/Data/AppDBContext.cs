using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPITempalate.Domain;

namespace WebAPITempalate.Infrastructure
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            Pricebook2Items = Set<Pricebook2Items>();
        }
        public DbSet<Pricebook2Items> Pricebook2Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pricebook2Items>()
            .ToTable("Pricebook2Items");

            modelBuilder.Entity<Pricebook2Items>()
           .HasKey(p => p.Store);
            modelBuilder.Entity<Pricebook2Items>()
           .HasKey(p => p.Sku);
        }
    }
}
