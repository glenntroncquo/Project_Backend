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
        Task<List<Employee>> GetEmployees(bool includeDepartments);
        Task<Employee> GetEmployee(Guid employeeId);
        Task<Employee> AddEmployee(Employee employee);
        Task DeleteEmployee(Guid employeeId);
    }
    public class EmployeeRepository : IEmployeeRepository
    {
        private IProjectBackendContext _context;
        public EmployeeRepository(IProjectBackendContext context)
        {
            _context = context;
            
        }

        public async Task<List<Employee>> GetEmployees(bool includeDepartments)
        {
            if(includeDepartments)
            return await _context.Employees.Include(e => e.DepartmentEmployees)
            .ThenInclude(e => e.Department)
            .ThenInclude(c => c.Location)
            .ToListAsync();

            else return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployee(Guid employeeId)
        {
            return await _context.Employees.Where(e => e.EmployeeId == employeeId).SingleOrDefaultAsync();
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task DeleteEmployee(Guid employeeId)
        {
            var employee = await _context.Employees.Where(e => e.EmployeeId == employeeId).SingleOrDefaultAsync<Employee>();
            if(employee != null){
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }
        }
    }
}