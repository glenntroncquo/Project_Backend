using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Project_Backend.Models 
{
    public class Department 
    {
        public Guid DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        // [JsonIgnore]
        public Location Location { get; set; }
        [JsonIgnore]
        public List<DepartmentEmployee> DepartmentEmployee { get; set; }
    }
}