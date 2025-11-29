using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagementAppWeb.Migrations
{
    /// <inheritdoc />
    public partial class FirstCreationofSchoolManagementAppDatabse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentDetailsForDropdown",
                columns: table => new
                {
                    student_registration_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    student_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDetailsForDropdown", x => x.student_registration_Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentInfo",
                columns: table => new
                {
                    student_registration_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    student_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_roll_number = table.Column<int>(type: "int", nullable: false),
                    student_mobile_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_class = table.Column<int>(type: "int", nullable: false),
                    student_section_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentInfo", x => x.student_registration_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentDetailsForDropdown");

            migrationBuilder.DropTable(
                name: "StudentInfo");
        }
    }
}
