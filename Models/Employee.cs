using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_Backend.Models 
{
    public class Employee 
    {
        public Guid EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(18,120)]
        public int Age { get; set; }
        [Required]
        [Phone]
        public int PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string HireDate { get; set; }
        public ICollection<Project> Project { get; set; }
        public ICollection<Department> Department { get; set; }
    }
}