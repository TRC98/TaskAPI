using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class AuthorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Author_AuthorId",
                table: "Todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "Authors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Author");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 4, 13, 15, 41, 51, 122, DateTimeKind.Local).AddTicks(2079), new DateTime(2022, 4, 18, 15, 41, 51, 122, DateTimeKind.Local).AddTicks(8488) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 4, 13, 15, 41, 51, 123, DateTimeKind.Local).AddTicks(150), new DateTime(2022, 4, 18, 15, 41, 51, 123, DateTimeKind.Local).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 4, 13, 15, 41, 51, 123, DateTimeKind.Local).AddTicks(174), new DateTime(2022, 4, 18, 15, 41, 51, 123, DateTimeKind.Local).AddTicks(176) });

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Author_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
