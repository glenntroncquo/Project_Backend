using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Project_Backend.Configuration;

namespace Project_Backend.data
{
    public class ProjectBackendContext : DbContext
    {
        private ConnectionStrings _connectionstrings;
        public ProjectBackendContext(DbContextOptions options, IOptions<ConnectionStrings> connectionstrings) 
        : base(options)
        {
            _connectionstrings = connectionstrings.Value;
            
        }
    }
}