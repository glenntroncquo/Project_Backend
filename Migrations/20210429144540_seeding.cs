using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_Backend.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("d32df572-23ab-4516-b58b-5ba507a097e5"), new Guid("0ae767ca-651c-415f-bf26-ca7b1306d9c4") });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("bf2d081c-7247-4f44-8e35-3557d131ab9b"), new Guid("1cd69d9b-c4b0-4afd-86f5-8dec5cd0f228") });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("8594380c-fc31-458d-aac3-c247938f902f"), new Guid("53c29d7c-0fc5-4584-9359-58d7283b812b") });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("bf2d081c-7247-4f44-8e35-3557d131ab9b"), new Guid("53c29d7c-0fc5-4584-9359-58d7283b812b") });

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("92a99e7b-7ddb-417d-8510-9e4a33d863c6"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("c3f3b9b8-111a-4443-b980-b942dd2532ad"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("e1c1bd35-a410-408b-82f0-4df8e66b681f"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: new Guid("2c52d3df-f4e7-493d-bde4-867bae00c460"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: new Guid("3ac22041-3f85-40d7-9620-0a5f86981586"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: new Guid("cf51e187-b796-49bf-83a9-586826584f39"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: new Guid("8594380c-fc31-458d-aac3-c247938f902f"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: new Guid("bf2d081c-7247-4f44-8e35-3557d131ab9b"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: new Guid("d32df572-23ab-4516-b58b-5ba507a097e5"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: new Guid("0ae767ca-651c-415f-bf26-ca7b1306d9c4"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: new Guid("1cd69d9b-c4b0-4afd-86f5-8dec5cd0f228"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: new Guid("53c29d7c-0fc5-4584-9359-58d7283b812b"));

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
                        name: "FK_DepartmentEmployees_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentEmployees_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { new Guid("cdd2b38a-ef2b-4036-98b4-dbedfa8c5682"), "Weide" },
                    { new Guid("c95f2ab1-770a-470c-9340-eef2c5bc755b"), "Penta" },
                    { new Guid("22a030ab-3afb-4ab3-9bce-0085b1a451e0"), "Obeee" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "Age", "Email", "FirstName", "HireDate", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("2df20a1e-d5ac-4af6-8b80-78398790810a"), 18, "johndoe@gmail.com", "John", "20/06/2015", "Doe", 496054388 },
                    { new Guid("f4a96a61-9d10-4ed1-b49d-8ee45c3cb4e1"), 18, "charliechoplin@gmail.com", "Charlie", "20/06/2015", "Choplin", 496054388 },
                    { new Guid("b625c565-ddfa-4ef9-b765-5238fd298cf5"), 18, "rickertdemeester@gmail.com", "Rickert", "20/06/2015", "Demeester", 496054388 }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "Description", "ProjectName" },
                values: new object[,]
                {
                    { new Guid("6877b879-c728-474a-a699-7a13662826eb"), "Make a design", "Design" },
                    { new Guid("c2afa3bc-56e7-4c5e-9799-321122b2283f"), "Make a frontend", "Frontend" },
                    { new Guid("7a5d6b35-70a9-45be-bbc7-c46353021615"), "Make a backend", "Backend" }
                });

            migrationBuilder.InsertData(
                table: "DepartmentEmployees",
                columns: new[] { "DepartmentId", "EmployeeId" },
                values: new object[,]
                {
                    { new Guid("cdd2b38a-ef2b-4036-98b4-dbedfa8c5682"), new Guid("2df20a1e-d5ac-4af6-8b80-78398790810a") },
                    { new Guid("c95f2ab1-770a-470c-9340-eef2c5bc755b"), new Guid("2df20a1e-d5ac-4af6-8b80-78398790810a") },
                    { new Guid("c95f2ab1-770a-470c-9340-eef2c5bc755b"), new Guid("f4a96a61-9d10-4ed1-b49d-8ee45c3cb4e1") },
                    { new Guid("22a030ab-3afb-4ab3-9bce-0085b1a451e0"), new Guid("b625c565-ddfa-4ef9-b765-5238fd298cf5") }
                });

            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[,]
                {
                    { new Guid("2df20a1e-d5ac-4af6-8b80-78398790810a"), new Guid("6877b879-c728-474a-a699-7a13662826eb") },
                    { new Guid("2df20a1e-d5ac-4af6-8b80-78398790810a"), new Guid("c2afa3bc-56e7-4c5e-9799-321122b2283f") },
                    { new Guid("f4a96a61-9d10-4ed1-b49d-8ee45c3cb4e1"), new Guid("c2afa3bc-56e7-4c5e-9799-321122b2283f") },
                    { new Guid("b625c565-ddfa-4ef9-b765-5238fd298cf5"), new Guid("7a5d6b35-70a9-45be-bbc7-c46353021615") }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationId", "City", "DepartmentId", "HouseNumber", "PostalCode", "StreetName" },
                values: new object[,]
                {
                    { new Guid("3d0d37e8-9b98-4546-8211-1ac4db9c50b4"), "Kortrijk", new Guid("cdd2b38a-ef2b-4036-98b4-dbedfa8c5682"), 14, 8000, "Kortrijkstraat" },
                    { new Guid("884d635c-15f3-47cd-9f15-b3f74c21b74b"), "Kortrijk", new Guid("c95f2ab1-770a-470c-9340-eef2c5bc755b"), 18, 8000, "Kortrijkstraat" },
                    { new Guid("e300650c-f7f4-4d0c-9091-258450c67ee0"), "Kortrijk", new Guid("22a030ab-3afb-4ab3-9bce-0085b1a451e0"), 20, 8000, "Kortrijkstraat" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentEmployees_DepartmentId",
                table: "DepartmentEmployees",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentEmployees");

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("2df20a1e-d5ac-4af6-8b80-78398790810a"), new Guid("6877b879-c728-474a-a699-7a13662826eb") });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("b625c565-ddfa-4ef9-b765-5238fd298cf5"), new Guid("7a5d6b35-70a9-45be-bbc7-c46353021615") });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("2df20a1e-d5ac-4af6-8b80-78398790810a"), new Guid("c2afa3bc-56e7-4c5e-9799-321122b2283f") });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { new Guid("f4a96a61-9d10-4ed1-b49d-8ee45c3cb4e1"), new Guid("c2afa3bc-56e7-4c5e-9799-321122b2283f") });

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("3d0d37e8-9b98-4546-8211-1ac4db9c50b4"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("884d635c-15f3-47cd-9f15-b3f74c21b74b"));

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: new Guid("e300650c-f7f4-4d0c-9091-258450c67ee0"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: new Guid("22a030ab-3afb-4ab3-9bce-0085b1a451e0"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: new Guid("c95f2ab1-770a-470c-9340-eef2c5bc755b"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: new Guid("cdd2b38a-ef2b-4036-98b4-dbedfa8c5682"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: new Guid("2df20a1e-d5ac-4af6-8b80-78398790810a"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: new Guid("b625c565-ddfa-4ef9-b765-5238fd298cf5"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: new Guid("f4a96a61-9d10-4ed1-b49d-8ee45c3cb4e1"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: new Guid("6877b879-c728-474a-a699-7a13662826eb"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: new Guid("7a5d6b35-70a9-45be-bbc7-c46353021615"));

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: new Guid("c2afa3bc-56e7-4c5e-9799-321122b2283f"));

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
        }
    }
}
