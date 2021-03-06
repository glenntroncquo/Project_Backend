using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_Backend.Models 
{
    public class EmployeeDepartmentDTO
    {
        public Guid EmployeeId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string HireDate { get; set; }
        public List<DepartmentEmployee> DepartmentEmployees {get; set; }
    }
}