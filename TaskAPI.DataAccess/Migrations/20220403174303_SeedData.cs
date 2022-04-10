using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, new DateTime(2022, 4, 3, 23, 13, 3, 78, DateTimeKind.Local).AddTicks(4009), "Get some text books for school", new DateTime(2022, 4, 8, 23, 13, 3, 78, DateTimeKind.Local).AddTicks(9914), 0, "Get books for school - DB" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
