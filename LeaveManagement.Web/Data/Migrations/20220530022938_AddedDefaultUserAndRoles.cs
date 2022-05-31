using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUserAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "50c0c959-9b16-444a-a543-49f5c09ce57e", "3b8795d1-35e4-4462-96b8-af7a151d6542", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70ccb959-9b16-464a-a546-49f5c09ce57e", "882525cd-fec3-4b38-b2f7-6b8eaa0bb72b", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateofBirth", "Email", "EmailConfirmed", "EmployeeId", "FirstName", "LastNames", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "aaccbb00-9b16-464a-a546-49f5c09ce57e", 0, "06556a16-7b4d-4845-8eb6-49e549fe1654", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, null, "System", "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEF1m5kXQXyPA59Ne5MhOEONsHzGI5wyBnGdQo0oFS3j08KYLxnl2HIYU4vMKk/VJMQ==", null, false, "4267cf81-eb1a-43f2-bd06-f4b115cad17f", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "70ccb959-9b16-464a-a546-49f5c09ce57e", "aaccbb00-9b16-464a-a546-49f5c09ce57e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50c0c959-9b16-444a-a543-49f5c09ce57e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "70ccb959-9b16-464a-a546-49f5c09ce57e", "aaccbb00-9b16-464a-a546-49f5c09ce57e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70ccb959-9b16-464a-a546-49f5c09ce57e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aaccbb00-9b16-464a-a546-49f5c09ce57e");
        }
    }
}
