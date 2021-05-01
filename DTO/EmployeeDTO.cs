using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_Backend.Models 
{
    public class EmployeeDTO
    {
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        [Required]
        public string Name { get; set; }
    }
}