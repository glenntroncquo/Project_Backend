using System;
using AutoMapper;
using Project_Backend.Models;
using Project_Backend.DTO;

namespace Project_Backend.DTO
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Employee, EmployeeDTO>();
        }
    }
}