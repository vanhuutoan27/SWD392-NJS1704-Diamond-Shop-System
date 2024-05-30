using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiamonShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAddressAndRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2244), new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2419), new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2416), new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2413), new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2339), new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2336), new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2333), new DateTime(2024, 5, 28, 11, 41, 33, 103, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ab8e4032-2d95-45cc-89c1-c039e9e8bc39"),
                column: "Name",
                value: "DeliveryStaff");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[] { new Guid("1401744d-0421-41eb-b9d6-f888aaccca91"), null, "Nhân Viên Giao Hàng", "SaleStaff", "DELIVERYSTAFF" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1401744d-0421-41eb-b9d6-f888aaccca91"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4653), new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4838), new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4835), new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4832), new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4751), new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4749), new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4745), new DateTime(2024, 5, 23, 16, 2, 15, 835, DateTimeKind.Local).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ab8e4032-2d95-45cc-89c1-c039e9e8bc39"),
                column: "Name",
                value: "Delivery Staff");
        }
    }
}
