using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
        public int PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string HireDate { get; set; }
        [JsonIgnore]
        public List<EmployeeProject> EmployeeProject { get; set; }
        [JsonIgnore]
        public List<DepartmentEmployee> DepartmentEmployees { get; set; }
    }
}