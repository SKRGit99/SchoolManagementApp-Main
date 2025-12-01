using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementAppWeb.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class ModifyingtheRoleandUSerIDs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "227927f4-33e4-4baa-9edb-a6631bca1227", "227927f4-33e4-4baa-9edb-a6631bca1227", "Educator", "Educator" },
                    { "77c42450-7226-439b-92cd-bfc826d26cb6", "77c42450-7226-439b-92cd-bfc826d26cb6", "Admin", "Admin" },
                    { "9f4b4f1d-b7a9-4019-a6fe-7af3ffc1bca3", "9f4b4f1d-b7a9-4019-a6fe-7af3ffc1bca3", "Student", "Student" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d6a53300-8a84-4e49-b23a-ae7dd540d59c", 0, "95eff7a9-ddbd-4f4b-b882-5a2a0c17ba3d", "director@ABCSchool.com", false, false, null, "DIRECTOR@ABCSCHOOL.COM", "DIRECTOR@ABCSCHOOL.COM", "AQAAAAIAAYagAAAAEKKVOg/rCUbMKN91AeTvk0COPJi8MJYzOoOCmDAuVR5qdwWd03XdVf6T1VL2bp+Qlw==", null, false, "77359465-3949-42dd-8e1c-6e9d0b3cdf0b", false, "director@ABCSchool.com" },
                    { "eb2b606e-e91e-424a-8e4a-1590c018b3b9", 0, "1b86381d-e08a-4f3a-86c1-fcd81906ea0c", "student@ABCSchool.com", false, false, null, "STUDENT@ABCSCHOOL.COM", "STUDENT@ABCSCHOOL.COM", "AQAAAAIAAYagAAAAEL52i4CYVzglrAbvUBGYevJS6flZ01ju5s4JSAVlx5OgTblzeS/9BLYLzKyv9hcdMg==", null, false, "7152fb8e-8532-4a2c-bcd4-cd9e46736aeb", false, "student@ABCSchool.com" },
                    { "f523b7d8-ad00-4584-8c1e-4a0634f0ccdc", 0, "8e709290-07d5-4159-9758-b6fa609ddd44", "educator@ABCSchool.com", false, false, null, "EDUCATOR@ABCSCHOOL.COM", "EDUCATOR@ABCSCHOOL.COM", "AQAAAAIAAYagAAAAEL0D1pxyxkk+CaMZzL8CWMg1s5uF0Ms8+83gC/LIPw/TFtoOwZo+yWjKc6orc8cWEw==", null, false, "33da5e19-90e3-43a4-8b3a-cd6a59dc2532", false, "educator@ABCSchool.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "227927f4-33e4-4baa-9edb-a6631bca1227", "d6a53300-8a84-4e49-b23a-ae7dd540d59c" },
                    { "77c42450-7226-439b-92cd-bfc826d26cb6", "d6a53300-8a84-4e49-b23a-ae7dd540d59c" },
                    { "9f4b4f1d-b7a9-4019-a6fe-7af3ffc1bca3", "d6a53300-8a84-4e49-b23a-ae7dd540d59c" },
                    { "9f4b4f1d-b7a9-4019-a6fe-7af3ffc1bca3", "eb2b606e-e91e-424a-8e4a-1590c018b3b9" },
                    { "227927f4-33e4-4baa-9edb-a6631bca1227", "f523b7d8-ad00-4584-8c1e-4a0634f0ccdc" },
                    { "9f4b4f1d-b7a9-4019-a6fe-7af3ffc1bca3", "f523b7d8-ad00-4584-8c1e-4a0634f0ccdc" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "227927f4-33e4-4baa-9edb-a6631bca1227", "d6a53300-8a84-4e49-b23a-ae7dd540d59c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "77c42450-7226-439b-92cd-bfc826d26cb6", "d6a53300-8a84-4e49-b23a-ae7dd540d59c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9f4b4f1d-b7a9-4019-a6fe-7af3ffc1bca3", "d6a53300-8a84-4e49-b23a-ae7dd540d59c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9f4b4f1d-b7a9-4019-a6fe-7af3ffc1bca3", "eb2b606e-e91e-424a-8e4a-1590c018b3b9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "227927f4-33e4-4baa-9edb-a6631bca1227", "f523b7d8-ad00-4584-8c1e-4a0634f0ccdc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9f4b4f1d-b7a9-4019-a6fe-7af3ffc1bca3", "f523b7d8-ad00-4584-8c1e-4a0634f0ccdc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "227927f4-33e4-4baa-9edb-a6631bca1227");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77c42450-7226-439b-92cd-bfc826d26cb6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f4b4f1d-b7a9-4019-a6fe-7af3ffc1bca3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6a53300-8a84-4e49-b23a-ae7dd540d59c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb2b606e-e91e-424a-8e4a-1590c018b3b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f523b7d8-ad00-4584-8c1e-4a0634f0ccdc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "1", "Student", "Student" },
                    { "2", "2", "Educator", "Educator" },
                    { "3", "3", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4", 0, "df3d04c8-9f0f-4fe1-af85-cb1408799e35", "director@ABCSchool.com", false, false, null, "DIRECTOR@ABCSCHOOL.COM", "DIRECTOR@ABCSCHOOL.COM", "AQAAAAIAAYagAAAAEHxAh70qIvt/zlqjmb9wcxVpyLRW9PVm7iaBOBRFfjl6ANX96Px/J9FYeH4e0bDgDw==", null, false, "7adc3920-e4ad-42fd-8276-70390eb43add", false, "director@ABCSchool.com" },
                    { "5", 0, "7e07be4e-c70e-4673-ac52-1e3309329a6c", "educator@ABCSchool.com", false, false, null, "EDUCATOR@ABCSCHOOL.COM", "EDUCATOR@ABCSCHOOL.COM", "AQAAAAIAAYagAAAAEKXRBxaaV69uecKLoAc3N4BWDChh/qpSXZE6TiLtj2O3G4AwOvDxyh/aaxwBmV+PKg==", null, false, "b38be98a-9034-4b78-9238-74f740014b78", false, "educator@ABCSchool.com" },
                    { "6", 0, "ab90b1f3-5bca-47bc-9baa-1a5cc85dccbe", "student@ABCSchool.com", false, false, null, "STUDENT@ABCSCHOOL.COM", "STUDENT@ABCSCHOOL.COM", "AQAAAAIAAYagAAAAEAEiIl/culGOgSQomUeRRXPSNsbYPQGhsZTLvyaYTlHwh1/T1E1L+0jUCVEeykQelw==", null, false, "73c9e97c-2d3c-457d-9e68-6557c650d00c", false, "student@ABCSchool.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "4" },
                    { "2", "4" },
                    { "3", "4" },
                    { "1", "5" },
                    { "2", "5" },
                    { "1", "6" }
                });
        }
    }
}
