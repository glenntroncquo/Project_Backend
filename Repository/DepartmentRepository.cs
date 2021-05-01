using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_Backend.data;
using Project_Backend.Models;

namespace Project_Backend.Repository
{
    public interface IDepartmentRepository
    {
        Task<List<Department>> GetDepartments();
        Task<Department> GetDepartment(Guid departmentId);
    }
    public class DepartmentRepository : IDepartmentRepository
    {
        private IProjectBackendContext _context;
        public DepartmentRepository(IProjectBackendContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> GetDepartments()
        {
            return await _context.Departments.ToListAsync();
        }

        public async Task<Department> GetDepartment(Guid departmentId)
        {
             return await _context.Departments.Where(e => e.DepartmentId == departmentId).SingleOrDefaultAsync();
        }
    }
}