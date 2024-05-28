using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiamonShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class DiamoonDB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 21, 5, 51, 902, DateTimeKind.Local).AddTicks(7525), new DateTime(2024, 5, 28, 21, 5, 51, 902, DateTimeKind.Local).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 21, 5, 51, 902, DateTimeKind.Local).AddTicks(7829), new DateTime(2024, 5, 28, 21, 5, 51, 902, DateTimeKind.Local).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 21, 5, 51, 902, DateTimeKind.Local).AddTicks(7825), new DateTime(2024, 5, 28, 21, 5, 51, 902, DateTimeKind.Local).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 21, 5, 51, 902, DateTimeKind.Local).AddTicks(7820), new DateTime(2024, 5, 28, 21, 5, 51, 902, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 21, 5, 51, 902, DateTimeKind.Local).AddTicks(7714), new DateTime(2024, 5, 28, 21, 5, 51, 902, DateTimeKind.Local).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 21, 5, 51, 902, DateTimeKind.Local).AddTicks(7709), new DateTime(2024, 5, 28, 21, 5, 51, 902, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 21, 5, 51, 902, DateTimeKind.Local).AddTicks(7704), new DateTime(2024, 5, 28, 21, 5, 51, 902, DateTimeKind.Local).AddTicks(7705) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(8107), new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(8104), new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(8097), new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(7868), new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(7863), new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(7858), new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(7859) });
        }
    }
}
