using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_Backend.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Project_ProjectId",
                table: "EmployeeProject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "EmployeeProject",
                newName: "ProjectsProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeProject_ProjectId",
                table: "EmployeeProject",
                newName: "IX_EmployeeProject_ProjectsProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Projects_ProjectsProjectId",
                table: "EmployeeProject",
                column: "ProjectsProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Projects_ProjectsProjectId",
                table: "EmployeeProject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.RenameColumn(
                name: "ProjectsProjectId",
                table: "EmployeeProject",
                newName: "ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeProject_ProjectsProjectId",
                table: "EmployeeProject",
                newName: "IX_EmployeeProject_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Project_ProjectId",
                table: "EmployeeProject",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
