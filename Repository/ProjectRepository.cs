using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_Backend.data;
using Project_Backend.Models;

namespace Project_Backend.Repository
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetProjects();
        Task<Project> AddProject(Project project);
        Task DeleteProject(Guid projectId);
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
            return await _context.Projects.Include(p => p.EmployeeProject)
            .ThenInclude(b => b.Employee)
            .ToListAsync();
        }

        public async Task<Project> AddProject(Project project)
        {
            await _context.Projects.AddAsync(project);
            await _context.SaveChangesAsync();
            return project;
        }

        public async Task DeleteProject(Guid projectId)
        {
            var project = _context.Projects.Where(p => p.ProjectId == projectId).SingleOrDefault();

            if(project != null) 
            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();
        }
    }
}