using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project_Backend.Models;

namespace Project_Backend.Controllers
{
    [ApiController]
    [Route("api")]
    public class EmployeesController : ControllerBase
    {
        public EmployeesController()
        {

        }

        [HttpGet]
        public async Task<ActionResult<Employee>> GetEmployees()
        {
            try{
                
            }
            catch{

            }
        }

        [HttpGet]
        [Route("departments")]
        public async Task<ActionResult<Department>> GetDepartments()
        {
            try{

            }
            catch{

            }
        }

        [HttpGet]
        

    }
}