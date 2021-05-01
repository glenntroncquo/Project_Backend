using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_Backend.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
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
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
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
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_Locations_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentEmployees",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentEmployees", x => new { x.EmployeeId, x.DepartmentId });
                    table.ForeignKey(
                        name: "FK_DepartmentEmployees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentEmployees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProjects",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProjects", x => new { x.ProjectId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { new Guid("184a2287-0d4f-423a-b2b2-4cc6b62fe6fe"), "Weide" },
                    { new Guid("3f6f8091-35ec-40bd-8071-01330f088de2"), "Penta" },
                    { new Guid("927362f9-7f66-4a2c-ba3b-9829fd9161d1"), "Obeee" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "Email", "FirstName", "HireDate", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("4848ca04-3fef-4c35-b3e5-afd50c10f794"), 18, "johndoe@gmail.com", "John", "20/06/2015", "Doe", 496054388 },
                    { new Guid("462c3667-9eb9-44e9-b8de-cd7c78b404ed"), 18, "charliechoplin@gmail.com", "Charlie", "20/06/2015", "Choplin", 496054388 },
                    { new Guid("32e19d63-03a5-4b3b-a361-cc75f994ae5f"), 18, "rickertdemeester@gmail.com", "Rickert", "20/06/2015", "Demeester", 496054388 }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Description", "ProjectName" },
                values: new object[,]
                {
                    { new Guid("d44a2c00-f08b-45e2-b546-659449195bd2"), "Make a design", "Design" },
                    { new Guid("cb8b6989-68d7-4484-99ca-c697fcc114ed"), "Make a frontend", "Frontend" },
                    { new Guid("ab7c2f48-13ab-42eb-92c8-e07f55f625f5"), "Make a backend", "Backend" }
                });

            migrationBuilder.InsertData(
                table: "DepartmentEmployees",
                columns: new[] { "DepartmentId", "EmployeeId" },
                values: new object[,]
                {
                    { new Guid("184a2287-0d4f-423a-b2b2-4cc6b62fe6fe"), new Guid("4848ca04-3fef-4c35-b3e5-afd50c10f794") },
                    { new Guid("3f6f8091-35ec-40bd-8071-01330f088de2"), new Guid("4848ca04-3fef-4c35-b3e5-afd50c10f794") },
                    { new Guid("3f6f8091-35ec-40bd-8071-01330f088de2"), new Guid("462c3667-9eb9-44e9-b8de-cd7c78b404ed") },
                    { new Guid("927362f9-7f66-4a2c-ba3b-9829fd9161d1"), new Guid("32e19d63-03a5-4b3b-a361-cc75f994ae5f") }
                });

            migrationBuilder.InsertData(
                table: "EmployeeProjects",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[,]
                {
                    { new Guid("4848ca04-3fef-4c35-b3e5-afd50c10f794"), new Guid("d44a2c00-f08b-45e2-b546-659449195bd2") },
                    { new Guid("4848ca04-3fef-4c35-b3e5-afd50c10f794"), new Guid("cb8b6989-68d7-4484-99ca-c697fcc114ed") },
                    { new Guid("462c3667-9eb9-44e9-b8de-cd7c78b404ed"), new Guid("cb8b6989-68d7-4484-99ca-c697fcc114ed") },
                    { new Guid("32e19d63-03a5-4b3b-a361-cc75f994ae5f"), new Guid("ab7c2f48-13ab-42eb-92c8-e07f55f625f5") }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "City", "DepartmentId", "HouseNumber", "PostalCode", "StreetName" },
                values: new object[,]
                {
                    { new Guid("95faa0b4-d5e2-408b-9bcc-6539fc3892a1"), "Kortrijk", new Guid("184a2287-0d4f-423a-b2b2-4cc6b62fe6fe"), 14, 8000, "Kortrijkstraat" },
                    { new Guid("35d8a64d-b363-47e5-b658-404813193058"), "Kortrijk", new Guid("3f6f8091-35ec-40bd-8071-01330f088de2"), 18, 8000, "Kortrijkstraat" },
                    { new Guid("9c64daa8-b4c4-4f52-b748-99104ebe66cb"), "Kortrijk", new Guid("927362f9-7f66-4a2c-ba3b-9829fd9161d1"), 20, 8000, "Kortrijkstraat" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentEmployees_DepartmentId",
                table: "DepartmentEmployees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjects_EmployeeId",
                table: "EmployeeProjects",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_DepartmentId",
                table: "Locations",
                column: "DepartmentId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentEmployees");

            migrationBuilder.DropTable(
                name: "EmployeeProjects");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
