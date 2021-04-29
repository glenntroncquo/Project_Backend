using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_Backend.Migrations
{
    public partial class seedingggù : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HireDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<int>(type: "int", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_Location_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProject",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProject", x => new { x.ProjectId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_EmployeeProject_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProject_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { new Guid("3ac22041-3f85-40d7-9620-0a5f86981586"), "Weide" },
                    { new Guid("2c52d3df-f4e7-493d-bde4-867bae00c460"), "Penta" },
                    { new Guid("cf51e187-b796-49bf-83a9-586826584f39"), "Obeee" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "Age", "Email", "FirstName", "HireDate", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("bf2d081c-7247-4f44-8e35-3557d131ab9b"), 18, "johndoe@gmail.com", "John", "20/06/2015", "Doe", 496054388 },
                    { new Guid("8594380c-fc31-458d-aac3-c247938f902f"), 18, "charliechoplin@gmail.com", "Charlie", "20/06/2015", "Choplin", 496054388 },
                    { new Guid("d32df572-23ab-4516-b58b-5ba507a097e5"), 18, "rickertdemeester@gmail.com", "Rickert", "20/06/2015", "Demeester", 496054388 }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "Description", "ProjectName" },
                values: new object[,]
                {
                    { new Guid("1cd69d9b-c4b0-4afd-86f5-8dec5cd0f228"), "Make a design", "Design" },
                    { new Guid("53c29d7c-0fc5-4584-9359-58d7283b812b"), "Make a frontend", "Frontend" },
                    { new Guid("0ae767ca-651c-415f-bf26-ca7b1306d9c4"), "Make a backend", "Backend" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[,]
                {
                    { new Guid("bf2d081c-7247-4f44-8e35-3557d131ab9b"), new Guid("1cd69d9b-c4b0-4afd-86f5-8dec5cd0f228") },
                    { new Guid("bf2d081c-7247-4f44-8e35-3557d131ab9b"), new Guid("53c29d7c-0fc5-4584-9359-58d7283b812b") },
                    { new Guid("8594380c-fc31-458d-aac3-c247938f902f"), new Guid("53c29d7c-0fc5-4584-9359-58d7283b812b") },
                    { new Guid("d32df572-23ab-4516-b58b-5ba507a097e5"), new Guid("0ae767ca-651c-415f-bf26-ca7b1306d9c4") }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationId", "City", "DepartmentId", "HouseNumber", "PostalCode", "StreetName" },
                values: new object[,]
                {
                    { new Guid("e1c1bd35-a410-408b-82f0-4df8e66b681f"), "Kortrijk", new Guid("3ac22041-3f85-40d7-9620-0a5f86981586"), 14, 8000, "Kortrijkstraat" },
                    { new Guid("92a99e7b-7ddb-417d-8510-9e4a33d863c6"), "Kortrijk", new Guid("2c52d3df-f4e7-493d-bde4-867bae00c460"), 18, 8000, "Kortrijkstraat" },
                    { new Guid("c3f3b9b8-111a-4443-b980-b942dd2532ad"), "Kortrijk", new Guid("cf51e187-b796-49bf-83a9-586826584f39"), 20, 8000, "Kortrijkstraat" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProject_EmployeeId",
                table: "EmployeeProject",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_DepartmentId",
                table: "Location",
                column: "DepartmentId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeProject");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
