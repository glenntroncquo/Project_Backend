using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Backend.data;
using Project_Backend.Models;
using Project_Backend.Services;

namespace Project_Backend.Controllers
{
    [ApiController]
    [Route("api")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private ProjectBackendContext _content;

        public EmployeesController(IEmployeeService employeeService, ProjectBackendContext context)
        {
            _employeeService = employeeService;   
            _content = context;
        }

        [HttpGet]
        [Route("employees")]
        public async Task<List<Employee>> GetEmployees()
        {

            try{
                return await _employeeService.GetEmployees();
            }
            catch(Exception ex){
                throw ex;
            }
        }

        [HttpGet]
        [Route("employee/{name}")]
        public async Task<List<Employee>> GetEmployee()
        {

            try{
                return await _employeeService.GetEmployees();
            }
            catch(Exception ex){
                throw ex;
            }
        }


        // [HttpGet]
        // [Route("departments")]
        // public async Task<ActionResult<Department>> GetDepartments()
        // {
        //     try{

        //     }
        //     catch{

        //     }
        // }

        // [HttpGet]
        // public async Task<ActionResult<Project>> GetProject()
        // {
        //     try{

        //     }
        //     catch{

        //     }
        // }
        

    }
}