using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    internal class EmployeeContext : DbContext
    {
        private readonly string connectionString;
        private string v;

        public EmployeeContext(string v)
        {
            this.v = v;
        }

        public EmployeeContext(string connectionString, object time)
        {
            this.connectionString = connectionString;
        }

       
        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                      optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
