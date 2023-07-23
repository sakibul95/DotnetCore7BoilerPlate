using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Helpers.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_BasicTest",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SysDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_BasicTest", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "tbl_BasicTest",
                columns: new[] { "id", "Country", "Name", "SysDate" },
                values: new object[,]
                {
                    { 1, "Bangladesh", "Sakib", new DateTime(2023, 7, 23, 17, 34, 57, 572, DateTimeKind.Local).AddTicks(3696) },
                    { 2, "USA", "John Doe", new DateTime(2023, 7, 23, 17, 34, 57, 572, DateTimeKind.Local).AddTicks(3708) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_BasicTest");
        }
    }
}
