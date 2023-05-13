using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductionApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    VAT = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stocks_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Code", "Color", "CreatedDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "01", null, new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5312), null, "Telefon" },
                    { 2, "02", null, new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5325), null, "Bilgisayar" },
                    { 3, "03", null, new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5327), null, "Tablet" },
                    { 4, "04", null, new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5328), null, "Tv" },
                    { 5, "05", null, new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5330), null, "Beyaz Eşya" },
                    { 6, "06", null, new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5332), null, "Oyun Konsolları" }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "Code", "CreatedDate", "Description", "GroupId", "ModifiedDate", "Name", "Price", "VAT" },
                values: new object[,]
                {
                    { 1, "152.11.001", new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5617), "Samsung Galaxy Z Fold3, Samsung Galaxy Z Fold3, Samsung Galaxy Z Fold3", 1, null, "Samsung Galaxy Z Fold3", 10707m, 18m },
                    { 2, "152.11.002", new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5621), "Samsung Galaxy Z Flip3, Samsung Galaxy Z Flip3, Samsung Galaxy Z Flip3", 1, null, "Samsung Galaxy Z Flip3", 10340m, 18m },
                    { 3, "152.11.003", new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5624), "Samsung Galaxy S20 FE (SM-G780G), Samsung Galaxy S20 FE (SM-G780G), Samsung Galaxy S20 FE (SM-G780G)", 1, null, "Samsung Galaxy S20 FE (SM-G780G)", 8068m, 18m },
                    { 4, "152.21.001", new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5626), "Apple iPhone 11 64 CB Siyah, Apple iPhone 11 64 CB Siyah, Apple iPhone 11 64 CB Siyah", 1, null, "Apple iPhone 11 64 CB Siyah", 10787m, 18m },
                    { 5, "152.21.002", new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5629), "Apple iPhone 12 64 CB Siyah, Apple iPhone 12 64 CB Siyah, Apple iPhone 12 64 CB Siyah", 1, null, "Apple iPhone 12 64 CB Siyah", 10787m, 18m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_GroupId",
                table: "Stocks",
                column: "GroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
