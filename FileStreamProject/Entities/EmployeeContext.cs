using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileStreamProject.Entities
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server = DESKTOP-4LH89G5; Database = FileStreamDB; Trusted_Connection = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(x => x.Document)
                .HasColumnType("VARBINARY(MAX) FILESTREAM");

            modelBuilder.Entity<Employee>()
                .Property(x => x.EmployeeGuid)
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .IsRequired();

            modelBuilder.Entity<Employee>()
                .HasAlternateKey(x => x.EmployeeGuid);
        }

    }
}
