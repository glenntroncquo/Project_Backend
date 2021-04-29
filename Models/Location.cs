using System;

namespace Project_Backend.Models 
{
    public class Location 
    {
        public Guid LocationId { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public int HouseNumber { get; set; }
        public int PostalCode { get; set; }
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}