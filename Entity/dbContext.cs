using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using catering.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using catering.ModelDto;
using catering.Infrastructure;
using Microsoft.AspNetCore.Identity;

namespace catering.Entity
{
    public class dbContext:IdentityDbContext<user>
    {
        public dbContext(DbContextOptions<dbContext> options):base(options)
        {
        }
        
        public DbSet<user> users { get; set; }
        public DbSet<category> category { get; set; }
        public DbSet<productProperty> properties { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<propertyvalue> propertyvalues { get; set; }
        public DbSet<productimage> productimages { get; set; }

        public DbSet<order> orders { get; set; }
        public DbSet<ordersummary> ordersummaries { get; set; }

        public DbSet<review> reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //使用identity必须添加
            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();
            
        }
    }
}
