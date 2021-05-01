using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
        [JsonIgnore]
        public Guid DepartmentId { get; set; }
        [JsonIgnore]
        public Department Department { get; set; }
    }
}