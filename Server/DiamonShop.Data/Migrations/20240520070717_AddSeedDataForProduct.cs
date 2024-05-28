using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiamonShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataForProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryImage", "DateCreated", "DateModified", "Description", "Name" },
                values: new object[] { new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), null, new DateTime(2024, 5, 20, 14, 7, 16, 678, DateTimeKind.Local).AddTicks(9789), new DateTime(2024, 5, 20, 14, 7, 16, 678, DateTimeKind.Local).AddTicks(9805), "Kim Cuong vien nhap khau ", "Kim Cương Viên" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "DateCreated", "DateModified", "Description", "Name", "Price", "Status" },
                values: new object[,]
                {
                    { new Guid("005da949-dd83-438b-9ee9-aea012d87068"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 5, 20, 14, 7, 16, 678, DateTimeKind.Local).AddTicks(9989), new DateTime(2024, 5, 20, 14, 7, 16, 678, DateTimeKind.Local).AddTicks(9989), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 5, 20, 14, 7, 16, 678, DateTimeKind.Local).AddTicks(9979), new DateTime(2024, 5, 20, 14, 7, 16, 678, DateTimeKind.Local).AddTicks(9980), "Kinh cương tự nhiên 99%", "Kim Cương Viên", 21924560.0, 0 },
                    { new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 5, 20, 14, 7, 16, 678, DateTimeKind.Local).AddTicks(9976), new DateTime(2024, 5, 20, 14, 7, 16, 678, DateTimeKind.Local).AddTicks(9977), "Kinh cương tự nhiên 100%", "Kim Cương Viên", 535790600.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Diamonds",
                columns: new[] { "DiamondId", "Certification", "Clarity", "ColorLevel", "DateCreated", "DateModified", "Fluorescence", "Price", "QualityOfCut", "Shape", "Size", "Weight" },
                values: new object[,]
                {
                    { new Guid("005da949-dd83-438b-9ee9-aea012d87068"), "GIA", "IF", "D", new DateTime(2024, 5, 20, 14, 7, 16, 679, DateTimeKind.Local).AddTicks(69), new DateTime(2024, 5, 20, 14, 7, 16, 679, DateTimeKind.Local).AddTicks(69), "MEDIUM", 32422800.0, "Excellent", "Round", 4.2999999999999998, 2.7000000000000002 },
                    { new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"), "GIA", "VS3", "D", new DateTime(2024, 5, 20, 14, 7, 16, 679, DateTimeKind.Local).AddTicks(66), new DateTime(2024, 5, 20, 14, 7, 16, 679, DateTimeKind.Local).AddTicks(67), "MEDIUM", 21924560.0, "Excellent", "Round", 4.4000000000000004, 2.5 },
                    { new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"), "GIA", "VVS2", "F", new DateTime(2024, 5, 20, 14, 7, 16, 679, DateTimeKind.Local).AddTicks(63), new DateTime(2024, 5, 20, 14, 7, 16, 679, DateTimeKind.Local).AddTicks(63), "MEDIUM", 535790600.0, "Excellent", "Pear", 4.4000000000000004, 1.5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"));

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"));

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"));

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"));
        }
    }
}
