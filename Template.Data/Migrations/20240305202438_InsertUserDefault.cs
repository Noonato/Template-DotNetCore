using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Template.Data.Migrations
{
    public partial class InsertUserDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { new Guid("af226a33-cb47-40ab-9910-84d4aa24e5a0"), "userdefault@template.com", "User Default" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af226a33-cb47-40ab-9910-84d4aa24e5a0"));
        }
    }
}
