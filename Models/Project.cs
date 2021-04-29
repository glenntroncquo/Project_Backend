using System;
using System.Collections;
using System.Collections.Generic;

namespace Project_Backend.Models 
{
    public class Project 
    {
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public List<EmployeeProject> EmployeeProject { get; set; }
    }
}