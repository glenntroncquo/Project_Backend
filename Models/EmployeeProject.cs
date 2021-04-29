using System;
using System.Text.Json.Serialization;

namespace Project_Backend.Models
{
    public class EmployeeProject 
    {
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
    }
}