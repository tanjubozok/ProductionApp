using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductionApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class EditingStokVatType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Stocks",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 1, 8, 18, 94, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 1, 8, 18, 94, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 1, 8, 18, 94, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 1, 8, 18, 94, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 1, 8, 18, 94, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 1, 8, 18, 94, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 1, 8, 18, 94, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 1, 8, 18, 94, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 1, 8, 18, 94, DateTimeKind.Local).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 1, 8, 18, 94, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 16, 1, 8, 18, 94, DateTimeKind.Local).AddTicks(3773));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Stocks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 13, 9, 23, 755, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 13, 9, 23, 755, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 13, 9, 23, 755, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 13, 9, 23, 755, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 13, 9, 23, 755, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 15, 13, 9, 23, 755, DateTimeKind.Local).AddTicks(4513));

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
    }
}
