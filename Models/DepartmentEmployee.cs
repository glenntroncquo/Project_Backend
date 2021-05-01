using System;
using System.Text.Json.Serialization;

namespace Project_Backend.Models
{
    public class DepartmentEmployee 
    {
        [JsonIgnore]
        public Guid EmployeeId { get; set; }
        [JsonIgnore]
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}