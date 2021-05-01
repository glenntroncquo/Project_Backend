using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Project_Backend.Models 
{
    public class Project 
    {
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        // [JsonIgnore]
        public List<EmployeeProject> EmployeeProject { get; set; }
    }
}