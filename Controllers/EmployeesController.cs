using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project_Backend.data;
using Project_Backend.Models;
using Project_Backend.Services;

namespace Project_Backend.Controllers
{
    [ApiController]
    [Route("api")]
    public class EmployeesController : ControllerBase
    {
        private readonly ILogger<EmployeesController> _logger;
        private readonly IEmployeeService _employeeService;

        public EmployeesController(ILogger<EmployeesController> logger, IEmployeeService employeeService)
        {
            _logger = logger;
            _employeeService = employeeService;
        }

        // get all employees
        [HttpGet]
        [Route("employees")]
        public async Task<ActionResult<List<Employee>>> GetEmployees()
        {

            try{
                return new OkObjectResult(await _employeeService.GetEmployees());
                // return await _employeeService.GetEmployees();
            }
            catch(Exception ex){
                throw ex;
            }
        }

        // get employee by id
        [HttpGet]
        [Route("employee/{employeeId}")]
        public async Task<ActionResult<List<Employee>>> GetEmployee(Guid employeeId)
        {

            try{
                return await _employeeService.GetEmployees();
            }
            catch(Exception ex){
                throw ex;
            }
        }

        // search employee by name
        // [HttpGet]
        // [Route("employee")]
        // public async Task<ActionResult<List<Employee>>> SearchEmployees(string name)
        // {
        //     try{
        //         return new OkObjectResult(await );
        //     }
        //     catch(Exception ex){
        //         throw ex;
        //     }
        // }


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