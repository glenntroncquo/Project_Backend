using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Project_Backend.Models;
using Project_Backend.Repository;

namespace Project_Backend.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();
        Task<EmployeeDTO> GetEmployee(Guid employeeId);
    }

    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;
        private IMapper _mapper;
        public EmployeeService(IMapper mapper,IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
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

        public async Task<EmployeeDTO> GetEmployee(Guid employeeId)
        {
            try{
                return _mapper.Map<EmployeeDTO>(await _employeeRepository.GetEmployee(employeeId));
            }
            catch(System.Exception ex){
                throw ex;
            }
        }

    }
}