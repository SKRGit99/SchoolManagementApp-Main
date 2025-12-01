using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagementAppWeb.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class AuthDatabaseissueresolution : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df3d04c8-9f0f-4fe1-af85-cb1408799e35", "AQAAAAIAAYagAAAAEHxAh70qIvt/zlqjmb9wcxVpyLRW9PVm7iaBOBRFfjl6ANX96Px/J9FYeH4e0bDgDw==", "7adc3920-e4ad-42fd-8276-70390eb43add" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e07be4e-c70e-4673-ac52-1e3309329a6c", "AQAAAAIAAYagAAAAEKXRBxaaV69uecKLoAc3N4BWDChh/qpSXZE6TiLtj2O3G4AwOvDxyh/aaxwBmV+PKg==", "b38be98a-9034-4b78-9238-74f740014b78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab90b1f3-5bca-47bc-9baa-1a5cc85dccbe", "AQAAAAIAAYagAAAAEAEiIl/culGOgSQomUeRRXPSNsbYPQGhsZTLvyaYTlHwh1/T1E1L+0jUCVEeykQelw==", "73c9e97c-2d3c-457d-9e68-6557c650d00c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6744e731-7dcf-4814-bdeb-8e6f93032cd6", "AQAAAAIAAYagAAAAEFV00yx6ZIA2Te6/vwEb3sYXQ3tQFW2bQkqQ/4Fs6aqDoc0F9FftB7AbqSWDk7Fx3w==", "17ba11ac-073d-4ecd-8a05-0f65fad1bcb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca2b8b08-fc66-4f73-8721-b9260176a434", "AQAAAAIAAYagAAAAEG6wZK3gSwOFyHXZkW9rrvvaY5xpzGMjHNNrO4BifEPzj7QhHYFHd8YNJgXS7nXBsw==", "458ab616-edb5-4707-8d38-0bbb764af38a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "911ae131-d9cb-46a7-ae2d-d68ff5cea0a4", "AQAAAAIAAYagAAAAEMaJfxaYF8NQMXpYc+BmrKLFPeeuu698s6XhOHqJH//ITmjvosiPXPoGtV+J8rVL+w==", "e22ef3ab-64d7-499b-8cb8-ecab48de330c" });
        }
    }
}
