using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Project_Backend.Configuration;
using Project_Backend.Models;

namespace Project_Backend.data
{
    public class ProjectBackendContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<DepartmentEmployee> DepartmentEmployees { get; set; }
        public DbSet<EmployeeProject> EmployeeProject { get; set; }

        private ConnectionStrings _connectionstrings;
        public ProjectBackendContext(DbContextOptions options, IOptions<ConnectionStrings> connectionstrings) 
        : base(options)
        {
            _connectionstrings = connectionstrings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_connectionstrings.SQL);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmentEmployee>()
            .HasKey(cs => new { cs.EmployeeId, cs.DepartmentId});

            modelBuilder.Entity<EmployeeProject>()
            .HasKey(cs => new { cs.ProjectId, cs.EmployeeId});
            
            // seeding Employee data
            Employee employee1 = new Employee(){
                EmployeeId = Guid.NewGuid(), 
                FirstName="John", 
                Name="Doe", 
                Age=18, 
                PhoneNumber=0496054388, 
                Email="johndoe@gmail.com", 
                HireDate="20/06/2015"
            };
            Employee employee2 = new Employee(){
                EmployeeId = Guid.NewGuid(), 
                FirstName="Charlie", 
                Name="Choplin", 
                Age=18, PhoneNumber=0496054388, 
                Email="charliechoplin@gmail.com", 
                HireDate="20/06/2015"
            };
            Employee employee3 = new Employee(){
                EmployeeId = Guid.NewGuid(), 
                FirstName="Rickert", 
                Name="Demeester", 
                Age=18, PhoneNumber=0496054388, 
                Email="rickertdemeester@gmail.com", 
                HireDate="20/06/2015"
            };

            // seeding Department data
            Department department1 = new Department(){
                DepartmentId = Guid.NewGuid(),
                DepartmentName = "Weide"
            };
            Department department2 = new Department(){
                DepartmentId = Guid.NewGuid(),
                DepartmentName = "Penta"
            };
            Department department3 = new Department(){
                DepartmentId = Guid.NewGuid(),
                DepartmentName = "Obeee"
            };

            // seeding Location data
            Location location1 = new Location(){
                LocationId = Guid.NewGuid(), 
                StreetName = "Kortrijkstraat", 
                City = "Kortrijk", 
                HouseNumber = 14, 
                PostalCode = 8000, 
                DepartmentId = department1.DepartmentId
            };
            Location location2 = new Location(){
                LocationId = Guid.NewGuid(), 
                StreetName = "Kortrijkstraat", 
                City = "Kortrijk", 
                HouseNumber = 18, 
                PostalCode = 8000, 
                DepartmentId = department2.DepartmentId
            };
            Location location3 = new Location(){
                LocationId = Guid.NewGuid(), 
                StreetName = "Kortrijkstraat", 
                City = "Kortrijk", 
                HouseNumber = 20, 
                PostalCode = 8000, 
                DepartmentId = department3.DepartmentId
            };

            Project project1 = new Project(){
                ProjectId = Guid.NewGuid(),
                ProjectName = "Design",
                Description = "Make a design"
            };
            Project project2 = new Project(){
                ProjectId = Guid.NewGuid(),
                ProjectName = "Frontend",
                Description = "Make a frontend"
            };
            Project project3 = new Project(){
                ProjectId = Guid.NewGuid(),
                ProjectName = "Backend",
                Description = "Make a backend"
            };

            // seeding many to many

            List<DepartmentEmployee> departmentEmployees = new List<DepartmentEmployee>(){
                new DepartmentEmployee(){
                    DepartmentId = department1.DepartmentId,
                    EmployeeId = employee1.EmployeeId
                },
                new DepartmentEmployee(){
                    DepartmentId = department2.DepartmentId,
                    EmployeeId = employee1.EmployeeId
                },
                new DepartmentEmployee(){
                    DepartmentId = department2.DepartmentId,
                    EmployeeId = employee2.EmployeeId
                },
                new DepartmentEmployee(){
                    DepartmentId = department3.DepartmentId,
                    EmployeeId = employee3.EmployeeId
                }
            };

            List<EmployeeProject> employeeProjects = new List<EmployeeProject>(){
                new EmployeeProject(){
                    EmployeeId = employee1.EmployeeId,
                    ProjectId = project1.ProjectId
                },
                new EmployeeProject(){
                    EmployeeId = employee1.EmployeeId,
                    ProjectId = project2.ProjectId
                },
                new EmployeeProject(){
                    EmployeeId = employee2.EmployeeId,
                    ProjectId = project2.ProjectId
                },
                new EmployeeProject(){
                    EmployeeId = employee3.EmployeeId,
                    ProjectId = project3.ProjectId
                }
            };

            // adding data to tables
            modelBuilder.Entity<Employee>().HasData(employee1, employee2, employee3);
            modelBuilder.Entity<Department>().HasData(department1, department2, department3);
            modelBuilder.Entity<Location>().HasData(location1, location2, location3);
            modelBuilder.Entity<Project>().HasData(project1, project2, project3);

            modelBuilder.Entity<DepartmentEmployee>().HasData(departmentEmployees);

            modelBuilder.Entity<EmployeeProject>().HasData(employeeProjects);

        }
    }
}