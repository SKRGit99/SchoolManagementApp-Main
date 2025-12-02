using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagementAppWeb.Migrations
{
    /// <inheritdoc />
    public partial class ModelClassandDBContextClasschanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentDetailsForDropdown",
                table: "StudentDetailsForDropdown");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducatorDetailsUsingList",
                table: "EducatorDetailsUsingList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducatorDetailsForDropdown",
                table: "EducatorDetailsForDropdown");

            migrationBuilder.RenameTable(
                name: "StudentDetailsForDropdown",
                newName: "StudentDetailsForDropdownEF");

            migrationBuilder.RenameTable(
                name: "EducatorDetailsUsingList",
                newName: "EducatorDetailsEF");

            migrationBuilder.RenameTable(
                name: "EducatorDetailsForDropdown",
                newName: "EducatorDetailsForDropdownEF");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentDetailsForDropdownEF",
                table: "StudentDetailsForDropdownEF",
                column: "student_registration_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducatorDetailsEF",
                table: "EducatorDetailsEF",
                column: "educator_registration_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducatorDetailsForDropdownEF",
                table: "EducatorDetailsForDropdownEF",
                column: "educator_registration_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentDetailsForDropdownEF",
                table: "StudentDetailsForDropdownEF");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducatorDetailsForDropdownEF",
                table: "EducatorDetailsForDropdownEF");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducatorDetailsEF",
                table: "EducatorDetailsEF");

            migrationBuilder.RenameTable(
                name: "StudentDetailsForDropdownEF",
                newName: "StudentDetailsForDropdown");

            migrationBuilder.RenameTable(
                name: "EducatorDetailsForDropdownEF",
                newName: "EducatorDetailsForDropdown");

            migrationBuilder.RenameTable(
                name: "EducatorDetailsEF",
                newName: "EducatorDetailsUsingList");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentDetailsForDropdown",
                table: "StudentDetailsForDropdown",
                column: "student_registration_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducatorDetailsForDropdown",
                table: "EducatorDetailsForDropdown",
                column: "educator_registration_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducatorDetailsUsingList",
                table: "EducatorDetailsUsingList",
                column: "educator_registration_Id");
        }
    }
}
