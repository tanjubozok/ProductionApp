using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductionApp.Repository.Migrations
{
    /// <inheritdoc />
    public partial class addingCustomerTypeSeeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CustomerTypes",
                columns: new[] { "Id", "AppUserId", "LongName", "ShortName" },
                values: new object[,]
                {
                    { 1, null, "Alıcı", "A" },
                    { 2, null, "Satıcı", "S" }
                });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 13, 16, 26, 532, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 13, 16, 26, 532, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 13, 16, 26, 532, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 13, 16, 26, 532, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 13, 16, 26, 532, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 13, 16, 26, 532, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 13, 16, 26, 532, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 13, 16, 26, 532, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 13, 16, 26, 532, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 13, 16, 26, 532, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 13, 16, 26, 532, DateTimeKind.Local).AddTicks(2915));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 12, 34, 52, 477, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 12, 34, 52, 477, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 12, 34, 52, 477, DateTimeKind.Local).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 12, 34, 52, 477, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 12, 34, 52, 477, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 12, 34, 52, 477, DateTimeKind.Local).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 12, 34, 52, 477, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 12, 34, 52, 477, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 12, 34, 52, 477, DateTimeKind.Local).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 12, 34, 52, 477, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 18, 12, 34, 52, 477, DateTimeKind.Local).AddTicks(4328));
        }
    }
}
