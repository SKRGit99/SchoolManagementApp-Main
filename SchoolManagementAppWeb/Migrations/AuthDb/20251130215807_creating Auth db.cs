using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagementAppWeb.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class creatingAuthdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "4", 0, "6744e731-7dcf-4814-bdeb-8e6f93032cd6", "director@ABCSchool.com", false, false, null, "DIRECTOR@ABCSCHOOL.COM", "DIRECTOR@ABCSCHOOL.COM", "AQAAAAIAAYagAAAAEFV00yx6ZIA2Te6/vwEb3sYXQ3tQFW2bQkqQ/4Fs6aqDoc0F9FftB7AbqSWDk7Fx3w==", null, false, "17ba11ac-073d-4ecd-8a05-0f65fad1bcb9", false, "director@ABCSchool.com" },
                    { "5", 0, "ca2b8b08-fc66-4f73-8721-b9260176a434", "educator@ABCSchool.com", false, false, null, "EDUCATOR@ABCSCHOOL.COM", "EDUCATOR@ABCSCHOOL.COM", "AQAAAAIAAYagAAAAEG6wZK3gSwOFyHXZkW9rrvvaY5xpzGMjHNNrO4BifEPzj7QhHYFHd8YNJgXS7nXBsw==", null, false, "458ab616-edb5-4707-8d38-0bbb764af38a", false, "educator@ABCSchool.com" },
                    { "6", 0, "911ae131-d9cb-46a7-ae2d-d68ff5cea0a4", "student@ABCSchool.com", false, false, null, "STUDENT@ABCSCHOOL.COM", "STUDENT@ABCSCHOOL.COM", "AQAAAAIAAYagAAAAEMaJfxaYF8NQMXpYc+BmrKLFPeeuu698s6XhOHqJH//ITmjvosiPXPoGtV+J8rVL+w==", null, false, "e22ef3ab-64d7-499b-8cb8-ecab48de330c", false, "student@ABCSchool.com" }
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "d6a53300-8a84-4e49-b23a-ae7dd540d59c", 0, "e1393d1f-74cc-4bb9-b18e-d55ec6108b92", "director@ABCSchool.com", false, false, null, "DIRECTOR@ABCSCHOOL.COM", "DIRECTOR@ABCSCHOOL.COM", "AQAAAAIAAYagAAAAECrjVljGTkusmEePJZIdHHjXbfkkSulWfL/3P7ZM6ZzkFS18teeDKK0vOIpX82/UqA==", null, false, "d17a4f41-cfc5-4fff-ac4e-b66e2f5f690f", false, "director@ABCSchool.com" },
                    { "eb2b606e-e91e-424a-8e4a-1590c018b3b9", 0, "a2dd9d4e-ab83-42f1-8717-d15f6db7cb66", "student@ABCSchool.com", false, false, null, "STUDENT@ABCSCHOOL.COM", "STUDENT@ABCSCHOOL.COM", "AQAAAAIAAYagAAAAEK4LS9rD2ZtTwSojfLo3AaBm3tcnaLeZmqO6CnFpNHyjbgVeonrhHB0btrKk4m0MFA==", null, false, "bc7bf04e-b002-4cb4-bbb7-669852236d7b", false, "student@ABCSchool.com" },
                    { "f523b7d8-ad00-4584-8c1e-4a0634f0ccdc", 0, "87df5fde-386e-42e8-a85b-e11cff018830", "educator@ABCSchool.com", false, false, null, "EDUCATOR@ABCSCHOOL.COM", "EDUCATOR@ABCSCHOOL.COM", "AQAAAAIAAYagAAAAEAcuwkLHy/rSJ/+PClJokKfkgRgh/Hcns1TZZLgPJ3gzPxIfTdqcLN0bcJ40KQ6MZg==", null, false, "e10842d7-c3da-4cb1-91e9-818e804ec444", false, "educator@ABCSchool.com" }
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
    }
}
