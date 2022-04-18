using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class AuthorEntityAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Fiqri Ismail" },
                    { 2, "Prabashwara Bandara" },
                    { 3, "Chaminda Sooriyapperuma" },
                    { 4, "Hansamali Gamage" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Created", "Due" },
                values: new object[] { 1, new DateTime(2022, 4, 13, 15, 41, 51, 122, DateTimeKind.Local).AddTicks(2079), new DateTime(2022, 4, 18, 15, 41, 51, 122, DateTimeKind.Local).AddTicks(8488) });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 2, 1, new DateTime(2022, 4, 13, 15, 41, 51, 123, DateTimeKind.Local).AddTicks(150), "Go to supermarket and buy some stuff", new DateTime(2022, 4, 18, 15, 41, 51, 123, DateTimeKind.Local).AddTicks(159), 0, "Need some grocceries" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 3, 2, new DateTime(2022, 4, 13, 15, 41, 51, 123, DateTimeKind.Local).AddTicks(174), "Buy new camera", new DateTime(2022, 4, 18, 15, 41, 51, 123, DateTimeKind.Local).AddTicks(176), 0, "Purchase camera" });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Author_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Author_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 4, 3, 23, 13, 3, 78, DateTimeKind.Local).AddTicks(4009), new DateTime(2022, 4, 8, 23, 13, 3, 78, DateTimeKind.Local).AddTicks(9914) });
        }
    }
}
