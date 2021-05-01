using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project_Backend.Models;
using Project_Backend.Repository;

namespace Project_Backend.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();
    }

    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            try{
                return await _employeeRepository.GetEmployees();
            }
            catch(System.Exception ex){
                throw ex;
            }
        }

    }
}