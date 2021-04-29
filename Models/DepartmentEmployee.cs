using System;
using System.Text.Json.Serialization;

namespace Project_Backend.Models
{
    public class DepartmentEmployee 
    {
  
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }
        public Department Department { get; set; }
        public Guid DepartmentId { get; set; }
    }
}