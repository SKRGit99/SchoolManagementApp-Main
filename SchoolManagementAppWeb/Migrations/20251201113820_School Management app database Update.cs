using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagementAppWeb.Migrations
{
    /// <inheritdoc />
    public partial class SchoolManagementappdatabaseUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentInfoEF");

            migrationBuilder.AlterColumn<string>(
                name: "student_name",
                table: "StudentDetailsForDropdown",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "EducatorDetailsForDropdown",
                columns: table => new
                {
                    educator_registration_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    educator_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducatorDetailsForDropdown", x => x.educator_registration_Id);
                });

            migrationBuilder.CreateTable(
                name: "EducatorDetailsUsingList",
                columns: table => new
                {
                    educator_registration_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    educator_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    educator_subject_assigned = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    educator_class_assigned = table.Column<int>(type: "int", nullable: false),
                    educator_section_assigned = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    educator_mobile_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    educator_address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducatorDetailsUsingList", x => x.educator_registration_Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentDetailsEF",
                columns: table => new
                {
                    student_registration_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    student_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    student_roll_number = table.Column<int>(type: "int", nullable: false),
                    student_mobile_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    student_class_details = table.Column<int>(type: "int", nullable: false),
                    student_section_details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    student_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    student_guardian_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDetailsEF", x => x.student_registration_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducatorDetailsForDropdown");

            migrationBuilder.DropTable(
                name: "EducatorDetailsUsingList");

            migrationBuilder.DropTable(
                name: "StudentDetailsEF");

            migrationBuilder.AlterColumn<string>(
                name: "student_name",
                table: "StudentDetailsForDropdown",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "StudentInfoEF",
                columns: table => new
                {
                    student_registration_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    student_Guardian_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_class = table.Column<int>(type: "int", nullable: false),
                    student_mobile_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_roll_number = table.Column<int>(type: "int", nullable: false),
                    student_section_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentInfoEF", x => x.student_registration_Id);
                });
        }
    }
}
