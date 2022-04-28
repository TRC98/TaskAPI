using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class Addeddataanotation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Todos",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdderessNo",
                table: "Authors",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Authors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Authors",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdderessNo", "City", "Street" },
                values: new object[] { "45", "Colombo 1", "Street 1" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AdderessNo", "City", "Street" },
                values: new object[] { "35", "Colombo 2", "Street 2" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdderessNo", "City", "Street" },
                values: new object[] { "25", "Colombo 3", "Street 3" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AdderessNo", "City", "Street" },
                values: new object[] { "15", "Colombo 4", "Street 4" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdderessNo",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Authors");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 4, 13, 20, 44, 45, 405, DateTimeKind.Local).AddTicks(4611), new DateTime(2022, 4, 18, 20, 44, 45, 405, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 4, 13, 20, 44, 45, 405, DateTimeKind.Local).AddTicks(9490), new DateTime(2022, 4, 18, 20, 44, 45, 405, DateTimeKind.Local).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 4, 13, 20, 44, 45, 405, DateTimeKind.Local).AddTicks(9506), new DateTime(2022, 4, 18, 20, 44, 45, 405, DateTimeKind.Local).AddTicks(9507) });
        }
    }
}
