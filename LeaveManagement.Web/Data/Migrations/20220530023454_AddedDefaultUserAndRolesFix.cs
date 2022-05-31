using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUserAndRolesFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50c0c959-9b16-444a-a543-49f5c09ce57e",
                column: "ConcurrencyStamp",
                value: "2d7ae969-9dcb-4ce8-9409-dd32c53c9dfd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70ccb959-9b16-464a-a546-49f5c09ce57e",
                column: "ConcurrencyStamp",
                value: "4e110f24-25ce-4d67-ad88-f28cf29c5853");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aaccbb00-9b16-464a-a546-49f5c09ce57e",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e875148b-55ec-4a0c-851e-6c298feed433", true, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEO5VpKGcyfqVIm20q9dWhh96rwVuLQQTd1B73Rcs2vZCh4nflLSB7RQ+BehaayeKXA==", "79edabe2-6090-4a49-800d-6495b85754a3", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50c0c959-9b16-444a-a543-49f5c09ce57e",
                column: "ConcurrencyStamp",
                value: "3b8795d1-35e4-4462-96b8-af7a151d6542");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70ccb959-9b16-464a-a546-49f5c09ce57e",
                column: "ConcurrencyStamp",
                value: "882525cd-fec3-4b38-b2f7-6b8eaa0bb72b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aaccbb00-9b16-464a-a546-49f5c09ce57e",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "06556a16-7b4d-4845-8eb6-49e549fe1654", false, null, null, "AQAAAAEAACcQAAAAEF1m5kXQXyPA59Ne5MhOEONsHzGI5wyBnGdQo0oFS3j08KYLxnl2HIYU4vMKk/VJMQ==", "4267cf81-eb1a-43f2-bd06-f4b115cad17f", null });
        }
    }
}
