using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiamonShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataForRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9059), new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9449), new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9446), new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9443), new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9167), new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9163), new DateTime(2024, 5, 23, 11, 17, 15, 901, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), null, "Khách Hàng", "Customer", "CUSTOMER" },
                    { new Guid("ab8e4032-2d95-45cc-89c1-c039e9e8bc39"), null, "Nhân Viên Giao Hàng", "Delivery Staff", "DELIVERYSTAFF" },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), null, "Quản Lí", "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ab8e4032-2d95-45cc-89c1-c039e9e8bc39"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"));

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 20, 14, 7, 16, 678, DateTimeKind.Local).AddTicks(9789), new DateTime(2024, 5, 20, 14, 7, 16, 678, DateTimeKind.Local).AddTicks(9805) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 20, 14, 7, 16, 679, DateTimeKind.Local).AddTicks(69), new DateTime(2024, 5, 20, 14, 7, 16, 679, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 20, 14, 7, 16, 679, DateTimeKind.Local).AddTicks(66), new DateTime(2024, 5, 20, 14, 7, 16, 679, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 20, 14, 7, 16, 679, DateTimeKind.Local).AddTicks(63), new DateTime(2024, 5, 20, 14, 7, 16, 679, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 20, 14, 7, 16, 678, DateTimeKind.Local).AddTicks(9989), new DateTime(2024, 5, 20, 14, 7, 16, 678, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 20, 14, 7, 16, 678, DateTimeKind.Local).AddTicks(9979), new DateTime(2024, 5, 20, 14, 7, 16, 678, DateTimeKind.Local).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 20, 14, 7, 16, 678, DateTimeKind.Local).AddTicks(9976), new DateTime(2024, 5, 20, 14, 7, 16, 678, DateTimeKind.Local).AddTicks(9977) });
        }
    }
}
