using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductionApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddingSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "CreatedDate" },
                values: new object[] { "secondary", new DateTime(2023, 5, 15, 13, 9, 23, 755, DateTimeKind.Local).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "CreatedDate" },
                values: new object[] { "warning", new DateTime(2023, 5, 15, 13, 9, 23, 755, DateTimeKind.Local).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "CreatedDate" },
                values: new object[] { "primary", new DateTime(2023, 5, 15, 13, 9, 23, 755, DateTimeKind.Local).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "CreatedDate" },
                values: new object[] { "dark", new DateTime(2023, 5, 15, 13, 9, 23, 755, DateTimeKind.Local).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "CreatedDate" },
                values: new object[] { "info", new DateTime(2023, 5, 15, 13, 9, 23, 755, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "CreatedDate" },
                values: new object[] { "success", new DateTime(2023, 5, 15, 13, 9, 23, 755, DateTimeKind.Local).AddTicks(4513) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 13, 9, 23, 755, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 13, 9, 23, 755, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 13, 9, 23, 755, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 13, 9, 23, 755, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 13, 9, 23, 755, DateTimeKind.Local).AddTicks(4835));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 14, 0, 33, 54, 265, DateTimeKind.Local).AddTicks(5629));
        }
    }
}
