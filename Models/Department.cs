using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_Backend.Models 
{
    public class Department 
    {
        public Guid DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        public Location Location { get; set; }
        public ICollection<Employee> Employee { get; set; }
    }
}