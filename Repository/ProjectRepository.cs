using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_Backend.data;
using Project_Backend.Models;

namespace Project_Backend.Repository
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetProjects();
    }
    public class ProjectRepository : IProjectRepository
    {
        private IProjectBackendContext _context;
        public ProjectRepository(IProjectBackendContext context)
        {
            _context = context;
        }

        public async Task<List<Project>> GetProjects()
        {
            return await _context.Projects.ToListAsync();
        }
    }
}