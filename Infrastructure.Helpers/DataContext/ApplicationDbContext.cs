using Infrastructure.Helpers.Models.BoilerPlateDb.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Helpers.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<tbl_BasicTest> tbl_BasicTest { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_BasicTest>()
            .HasData(
                new tbl_BasicTest
                {
                    id = 1,
                    Name = "Sakib",
                    Country = "Bangladesh",
                    SysDate = DateTime.Now
                },
                new tbl_BasicTest
                {
                    id = 2,
                    Name = "John Doe",
                    Country = "USA",
                    SysDate = DateTime.Now
                }
            );
        }
    }
}


/////////// For Auto migration run ////////////
///1st run below command
///Add-Migration InitialMigration -Project Infrastructure.Helpers -Context ApplicationDbContext -StartupProject WebApi
///2nd run below command
/// Update-Database
///


