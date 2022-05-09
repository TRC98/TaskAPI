using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class AddJobroleFieldToAuhtor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Authors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobRole",
                value: "System Engineer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobRole",
                value: "QA");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 5, 4, 13, 40, 50, 638, DateTimeKind.Local).AddTicks(17), new DateTime(2022, 5, 9, 13, 40, 50, 638, DateTimeKind.Local).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 5, 4, 13, 40, 50, 638, DateTimeKind.Local).AddTicks(4798), new DateTime(2022, 5, 9, 13, 40, 50, 638, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 5, 4, 13, 40, 50, 638, DateTimeKind.Local).AddTicks(4814), new DateTime(2022, 5, 9, 13, 40, 50, 638, DateTimeKind.Local).AddTicks(4815) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 4, 19, 12, 51, 1, 685, DateTimeKind.Local).AddTicks(4262), new DateTime(2022, 4, 24, 12, 51, 1, 686, DateTimeKind.Local).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 4, 19, 12, 51, 1, 686, DateTimeKind.Local).AddTicks(3042), new DateTime(2022, 4, 24, 12, 51, 1, 686, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 4, 19, 12, 51, 1, 686, DateTimeKind.Local).AddTicks(3070), new DateTime(2022, 4, 24, 12, 51, 1, 686, DateTimeKind.Local).AddTicks(3072) });
        }
    }
}
