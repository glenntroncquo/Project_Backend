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
        public async Task<ActionResult<List<EmployeeDepartmentDTO>>> GetEmployees(bool includeDepartments = false)
        {

            try{
                return new OkObjectResult(await _employeeService.GetEmployees(includeDepartments));
            }
            catch{
                return new StatusCodeResult(500);
            }
        }

        // get employee by id
        [HttpGet]
        [Route("employee/{employeeId}")]
        public async Task<ActionResult<List<EmployeeDTO>>> GetEmployee(Guid employeeId)
        {

            try{
                return new OkObjectResult(await _employeeService.GetEmployee(employeeId));
            }
            catch{
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        [Route("employees")]
        public async Task<ActionResult<EmployeeDTO>> AddEmployee(Employee employee)
        {
            try{
                return new OkObjectResult(await _employeeService.AddEmployee(employee));
            }
            catch{
                return new StatusCodeResult(500);
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