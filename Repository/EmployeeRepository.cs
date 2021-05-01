using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_Backend.data;
using Project_Backend.Models;

namespace Project_Backend.Repository
{
    public interface IEmployeeRepository 
    {
        Task<List<Employee>> GetEmployees();
        Task<Employee> GetEmployee(Guid employeeId);
    }
    public class EmployeeRepository : IEmployeeRepository
    {
        private IProjectBackendContext _context;
        public EmployeeRepository(IProjectBackendContext context)
        {
            _context = context;
            
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployee(Guid employeeId)
        {
            return await _context.Employees.Where(e => e.EmployeeId == employeeId).SingleOrDefaultAsync();
        }
    }
}