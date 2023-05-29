using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp2.Migrations.Data
{
    /// <inheritdoc />
    public partial class Comment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("001bf82e-ec29-4fbc-9a8c-cb7318a9c819"));

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Comment", "CompanyName", "Created", "Email", "Name", "PhoneNumber" },
                values: new object[] { new Guid("841bdba3-5463-4e7a-8e81-417358463da4"), "Hejsan", null, new DateTime(2023, 5, 29, 13, 28, 42, 254, DateTimeKind.Local).AddTicks(6284), "anton@domain.com", "Anton", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: new Guid("841bdba3-5463-4e7a-8e81-417358463da4"));

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Comment", "CompanyName", "Created", "Email", "Name", "PhoneNumber" },
                values: new object[] { new Guid("001bf82e-ec29-4fbc-9a8c-cb7318a9c819"), "Hejsan", null, new DateTime(2023, 5, 29, 13, 14, 38, 551, DateTimeKind.Local).AddTicks(8451), "anton@domain.com", "Anton", null });
        }
    }
}
