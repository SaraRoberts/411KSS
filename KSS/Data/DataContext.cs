using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KSS.Models;
using Microsoft.EntityFrameworkCore;

namespace KSS.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=411KSS;Trusted_Connection=True");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<User>().HasKey(x => x.Id);

            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Course>().HasKey(x => x.Id);

        }
    }
}