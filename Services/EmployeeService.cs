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
        Task<List<EmployeeDepartmentDTO>> GetEmployees(bool includeDepartments);
        Task<EmployeeDTO> GetEmployee(Guid employeeId);
        Task<EmployeeDTO> AddEmployee(Employee employee);
        Task DeleteEmployee(Guid employeeId);

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

        public async Task<List<EmployeeDepartmentDTO>> GetEmployees(bool includeDepartments)
        {
            try{
                return _mapper.Map<List<EmployeeDepartmentDTO>>(await _employeeRepository.GetEmployees(includeDepartments));
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

        public async Task<EmployeeDTO> AddEmployee(Employee employee)
        {
            try{
                employee.EmployeeId = Guid.NewGuid();
                return _mapper.Map<EmployeeDTO>(await _employeeRepository.AddEmployee(employee));
            }
            catch(Exception ex){
                throw ex;
            }
        }

        public async Task DeleteEmployee(Guid employeeId)
        {
            try{
                await _employeeRepository.DeleteEmployee(employeeId);
            }
            catch(Exception ex){
                throw ex;
            }
        }

    }
}