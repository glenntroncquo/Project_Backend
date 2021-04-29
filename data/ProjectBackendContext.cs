using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Project_Backend.Configuration;
using Project_Backend.Models;

namespace Project_Backend.data
{
    public class ProjectBackendContext : DbContext
    {
        public DbSet<Employee> Employee {get; set;}
        public DbSet<Project> Project {get; set;}
        public DbSet<Department> Department { get; set; }
        private ConnectionStrings _connectionstrings;
        public ProjectBackendContext(DbContextOptions options, IOptions<ConnectionStrings> connectionstrings) 
        : base(options)
        {
            _connectionstrings = connectionstrings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_connectionstrings.SQL);
        }

        
    }
}