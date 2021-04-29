using System;
using System.ComponentModel.DataAnnotations;

namespace Project_Backend.Models 
{
    public class Location 
    {
        public Guid LocationId { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public int HouseNumber { get; set; }
        [Required]
        public int PostalCode { get; set; }
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}