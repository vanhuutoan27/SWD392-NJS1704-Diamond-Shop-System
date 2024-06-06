using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiamonShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProductTYpeField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"));

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"));

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"));

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"));

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"));

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"));

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"));

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"));

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"));

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"));

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"));

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"));

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"));

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"));

            migrationBuilder.DeleteData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("0605b655-3916-4d57-88d1-d560f8e13996"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1e7c8cf2-8383-4eb0-a8ea-1f473b1dc573"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("29b11226-707a-4dc5-903e-60a559fa4d6e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("3473da8c-a0b6-4ad2-b373-ee17e9082cf4"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("37bfe329-8228-46f4-8e87-302f2d3a572c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("37e12364-6c3e-4668-86ee-6af9aa32b3f6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("3df041d3-b9c5-4b2c-b4f0-aa0f64329536"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("44f1549b-f096-4b6c-bee2-21c1dd89356d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("5c8694e7-842a-4abe-a661-7161b2f20de2"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("61300d05-6ca1-4fc5-977a-5c338115e462"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("61475897-81b3-4c3f-9948-68da2207f479"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("71858c84-f892-4d22-9af6-c62d18074211"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("7e3909a9-f4e8-4d02-a375-9c66d9f9a57e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("899560a6-78b2-413a-9644-5530daa3bb04"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("92bdb5fc-d7fc-4b95-bc1b-b704db5b1875"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("991b69d1-c5cd-4715-bc27-013e7dc28bbe"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("9c02d7b1-7bff-48cd-a50c-223a3fa5ddae"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("b4d9fe20-f6af-4f0e-bc4f-799bb1ae3977"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c20d846c-a73b-4356-8736-a51273667bee"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c4facd13-b7c5-47be-8d40-ddc34c84b69a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d98940e6-41ec-4d4f-b026-3479622e3966"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("e228740b-29c2-4909-8750-96da33eb21be"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("f31c347f-978f-45b2-9a17-128c622f1b7c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("f4b9a6fc-db48-40c2-9d89-1d0952b01318"));

            migrationBuilder.DeleteData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"));

            migrationBuilder.DeleteData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"));

            migrationBuilder.DeleteData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"));

            migrationBuilder.DeleteData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"));

            migrationBuilder.DeleteData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"));

            migrationBuilder.DeleteData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"));

            migrationBuilder.DeleteData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"));

            migrationBuilder.DeleteData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"));

            migrationBuilder.DeleteData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"));

            migrationBuilder.DeleteData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"));

            migrationBuilder.DeleteData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"));

            migrationBuilder.DeleteData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1401744d-0421-41eb-b9d6-f888aaccca91"));

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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"));

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"));

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"));

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"));

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"));

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"));

            migrationBuilder.AddColumn<string>(
                name: "ProductType",
                table: "Jewelrys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductType",
                table: "Diamonds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductType",
                table: "Jewelrys");

            migrationBuilder.DropColumn(
                name: "ProductType",
                table: "Diamonds");

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryImage", "DateCreated", "DateModified", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"), null, new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8863), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8863), null, "Earrings" },
                    { new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"), null, new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8857), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8857), null, "Ring" },
                    { new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"), null, new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8855), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8856), null, "Pendant" },
                    { new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), null, new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8839), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8850), "Kim Cuong vien nhap khau ", "Diamond" },
                    { new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"), null, new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8860), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8860), null, "Bracelet" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1401744d-0421-41eb-b9d6-f888aaccca91"), null, "Nhân Viên Bán Hàng", "SaleStaff", "SALESTAFF" },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), null, "Khách Hàng", "Customer", "CUSTOMER" },
                    { new Guid("ab8e4032-2d95-45cc-89c1-c039e9e8bc39"), null, "Nhân Viên Giao Hàng", "DeliveryStaff", "DELIVERYSTAFF" },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), null, "Quản Lí", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "DateCreated", "DateModified", "Description", "Name", "Price", "Status" },
                values: new object[,]
                {
                    { new Guid("005da949-dd83-438b-9ee9-aea012d87068"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8958), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8958), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9017), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9018), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9022), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9022), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8983), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8983), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9013), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9013), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8987), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8988), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8955), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8956), "Kinh cương tự nhiên 99%", "Kim Cương Viên", 21924560.0, 0 },
                    { new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9005), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9006), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8966), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8966), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9024), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9025), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9008), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9008), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9019), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9020), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8978), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8978), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8963), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8964), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8985), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8985), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8975), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8976), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"), new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8990), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8991), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8973), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8973), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9003), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9003), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("b9948c96-e456-471d-b523-159b7cf3242c"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8980), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8981), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9015), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9015), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9000), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9001), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8971), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8971), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8968), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8969), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8952), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8952), "Kinh cương tự nhiên 100%", "Kim Cương Viên", 535790600.0, 0 },
                    { new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9010), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9011), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("f376d66d-cf4a-4103-836f-43811290f18c"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8961), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(8961), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Diamonds",
                columns: new[] { "DiamondId", "Certification", "Clarity", "ColorLevel", "DateCreated", "DateModified", "Fluorescence", "Price", "QualityOfCut", "Shape", "Size", "SkuID", "Weight" },
                values: new object[,]
                {
                    { new Guid("005da949-dd83-438b-9ee9-aea012d87068"), "EGL", "I2", "F", new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9129), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9129), "Medium", 470000000.0, "Fair", "Round", 9.0999999999999996, "D003", 1.3999999999999999 },
                    { new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"), "AGS", "VVS2", "J", new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9156), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9156), "Faint", 21000000.0, "Fair", "Pear", 4.9000000000000004, "D013", 2.5 },
                    { new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"), "IGI", "I1", "L", new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9161), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9161), "Strong", 292740000.0, "Good", "Pear", 7.2000000000000002, "D015", 0.90000000000000002 },
                    { new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"), "AGS", "VS2", "D", new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9126), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9126), "Faint", 83000000.0, "Poor", "Round", 6.2000000000000002, "D002", 2.7999999999999998 },
                    { new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"), "GIA", "SL2", "I", new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9137), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9138), "Strong", 15900000.0, "Very Good", "Emerald", 4.5999999999999996, "D006", 0.80000000000000004 },
                    { new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"), "HRD", "VS1", "E", new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9151), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9151), "Strong", 668350000.0, "Excellent", "Cushion", 9.1999999999999993, "D011", 0.59999999999999998 },
                    { new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"), "IGI", "SL1", "J", new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9135), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9135), "Faint", 29400000.0, "Excellent", "Emerald", 5.2999999999999998, "D005", 3.1000000000000001 },
                    { new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"), "EGL", "VVS1", "K", new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9158), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9159), "None", 105740000.0, "Poor", "Pear", 6.2999999999999998, "D014", 3.2000000000000002 },
                    { new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"), "GIA", "VVS2", "M", new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9148), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9149), "Medium", 26000000.0, "Excellent", "Cushion", 5.0999999999999996, "D010", 1.3 },
                    { new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"), "IGI", "IF", "G", new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9146), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9146), "None", 61000000.0, "Poor", "Heart", 5.7999999999999998, "D009", 1.1899999999999999 },
                    { new Guid("b9948c96-e456-471d-b523-159b7cf3242c"), "HRD", "I1", "K", new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9153), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9154), "Strong", 392740000.0, "Very Good", "Cushion", 7.4000000000000004, "D012", 0.69999999999999996 },
                    { new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"), "EGL", "IF", "L", new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9143), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9144), "None", 268000000.0, "Fair", "Heart", 6.7999999999999998, "D008", 0.32000000000000001 },
                    { new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"), "AGS", "I2", "K", new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9141), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9141), "Medium", 615000000.0, "Good", "Heart", 8.6999999999999993, "D007", 0.40000000000000002 },
                    { new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"), "GIA", "IF", "E", new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9121), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9122), "None", 13500000.0, "Good", "Round", 4.4000000000000004, "D001", 0.31 },
                    { new Guid("f376d66d-cf4a-4103-836f-43811290f18c"), "HRD", "VVS1", "H", new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9131), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9131), "Strong", 364000000.0, "Very Good", "Emerald", 8.5, "D004", 2.1000000000000001 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "DateCreated", "DateModified", "Description", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("0605b655-3916-4d57-88d1-d560f8e13996"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m2.jpg?alt=media&token=c7c568ef-cd9b-4889-9fc2-96e478177e97" },
                    { new Guid("1e7c8cf2-8383-4eb0-a8ea-1f473b1dc573"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_4.jpg?alt=media&token=f0761d38-c205-48d8-89fd-84039af48ddf" },
                    { new Guid("29b11226-707a-4dc5-903e-60a559fa4d6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("3473da8c-a0b6-4ad2-b373-ee17e9082cf4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_4.jpg?alt=media&token=164f4d10-12f3-442c-81d2-eed699c79bd5" },
                    { new Guid("37bfe329-8228-46f4-8e87-302f2d3a572c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_3.jpg?alt=media&token=fc95d920-491f-4c8d-a50a-681673bb929d" },
                    { new Guid("37e12364-6c3e-4668-86ee-6af9aa32b3f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m2.jpg?alt=media&token=33c0ae2b-4f6d-4864-879d-a1c08be6d412" },
                    { new Guid("3df041d3-b9c5-4b2c-b4f0-aa0f64329536"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m1.jpg?alt=media&token=3788a61b-0bb2-40cd-a27f-da6d6c078939" },
                    { new Guid("44f1549b-f096-4b6c-bee2-21c1dd89356d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m1.jpg?alt=media&token=1c3dcb9b-9ba2-49e4-a39b-c6c7fa428bc6" },
                    { new Guid("5c8694e7-842a-4abe-a661-7161b2f20de2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m1.jpg?alt=media&token=5b52cbae-c5fd-4d97-8af8-5f2d5fb6df1b" },
                    { new Guid("61300d05-6ca1-4fc5-977a-5c338115e462"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_1.jpg?alt=media&token=42eda424-48f5-4586-a7e6-fda26c5659be" },
                    { new Guid("61475897-81b3-4c3f-9948-68da2207f479"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m2.jpg?alt=media&token=235c27dd-1417-46da-82ee-af820e415790" },
                    { new Guid("71858c84-f892-4d22-9af6-c62d18074211"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_1.jpg?alt=media&token=c8ef04f8-2a5e-4b64-a10e-b3693616f8a3" },
                    { new Guid("7e3909a9-f4e8-4d02-a375-9c66d9f9a57e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_1.jpg?alt=media&token=e313cc02-5436-487a-9a3b-71f4985fb733" },
                    { new Guid("899560a6-78b2-413a-9644-5530daa3bb04"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m2.jpg?alt=media&token=001430c6-ef62-4db7-96cf-678ebcd6dea5" },
                    { new Guid("92bdb5fc-d7fc-4b95-bc1b-b704db5b1875"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_3.jpg?alt=media&token=801a85ce-434c-4eee-9652-3672d8bb4482" },
                    { new Guid("991b69d1-c5cd-4715-bc27-013e7dc28bbe"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9419), null, null, new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_2.jpg?alt=media&token=7a80ce7c-4073-46f7-a1e9-aa9d2196bdd6" },
                    { new Guid("9c02d7b1-7bff-48cd-a50c-223a3fa5ddae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m1.jpg?alt=media&token=ce8862c1-380a-479e-a0e9-58634fa2d68a" },
                    { new Guid("b4d9fe20-f6af-4f0e-bc4f-799bb1ae3977"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m2.jpg?alt=media&token=7f01ab19-e4e8-42ea-8278-2ce5b7e50872" },
                    { new Guid("c20d846c-a73b-4356-8736-a51273667bee"), new DateTime(2024, 6, 5, 22, 4, 18, 83, DateTimeKind.Local).AddTicks(9386), null, null, new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_1.jpg?alt=media&token=ac90a06a-e325-4d08-bf75-5d6078da28f4" },
                    { new Guid("c4facd13-b7c5-47be-8d40-ddc34c84b69a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("d98940e6-41ec-4d4f-b026-3479622e3966"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m1.jpg?alt=media&token=ec5d2b70-753a-4485-a892-60c5c0938615" },
                    { new Guid("e228740b-29c2-4909-8750-96da33eb21be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_2.jpg?alt=media&token=42dc5653-5240-4df1-9b39-c4d1975defd7" },
                    { new Guid("f31c347f-978f-45b2-9a17-128c622f1b7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m2.jpg?alt=media&token=f5167a68-4c7a-46cf-ad28-e352ab8481e5" },
                    { new Guid("f4b9a6fc-db48-40c2-9d89-1d0952b01318"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m1.jpg?alt=media&token=2144ca96-674c-454e-b5c4-9141e98af6d7" }
                });

            migrationBuilder.InsertData(
                table: "Jewelrys",
                columns: new[] { "JewelryId", "GoldKarat", "GoldType", "GoldWeight", "MainStoneSize", "Name", "Price", "SkuID", "StoneWeight", "sideStoneQuantity", "sideStoneType" },
                values: new object[,]
                {
                    { new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "18K", "White gold", 5.9000000000000004, "Round 6.1ly", "18K DIAMOND BRACELET", 139800000.0, "J009", 2.7000000000000002, 57, "Diamond" },
                    { new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "18K", "White gold", 1.0800000000000001, "Round 5.3ly", "18K DIAMOND ERRINGS", 47239000.0, "J011", 0.10000000000000001, 60, "Diamond" },
                    { new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "18K", "White gold", 6.5999999999999996, "Round 5.4ly", "18K DIAMOND BRACELET", 135371000.0, "J007", 2.2000000000000002, 43, "Diamond" },
                    { new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "18K", "White gold", 1.05, "Round 4.5ly", "18K DIAMOND RING", 38589000.0, "J004", 1.0700000000000001, 38, "Diamond" },
                    { new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "18K", "White gold", 1.0700000000000001, "Round 4.9ly", "18K DIAMOND ERRINGS", 44650000.0, "J012", 0.029999999999999999, 23, "Diamond" },
                    { new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "18K", "White gold", 1.0900000000000001, "Round 4.0ly", "18K DIAMOND RING", 37430000.0, "J005", 2.0, 63, "Diamond" },
                    { new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "18K", "White gold", 1.04, "Round 5ly", "18K DIAMOND ERRINGS", 31317000.0, "J010", 0.040000000000000001, 15, "Diamond" },
                    { new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"), "18K", "White gold", 0.53000000000000003, "Round 5ly", "18K DIAMOND PENDANT", 28300000.0, "J001", 1.1000000000000001, 23, "Diamond" },
                    { new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "18K", "White gold", 0.57999999999999996, "Round 6.3ly", "18K DIAMOND PENDANT", 33450000.0, "J003", 1.2, 20, "Diamond" },
                    { new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "18K", "White gold", 7.0999999999999996, "Round 6.3ly", "18K DIAMOND BRACELET", 148239000.0, "J008", 2.7999999999999998, 92, "Diamond" },
                    { new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "18K", "White gold", 0.60999999999999999, "Round 5.1ly", "18K DIAMOND PENDANT", 31200000.0, "J002", 1.1200000000000001, 27, "Diamond" },
                    { new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "18K", "White gold", 1.1699999999999999, "Round 5.2ly", "18K DIAMOND RING", 41246000.0, "J006", 1.1000000000000001, 2, "Diamond" }
                });
        }
    }
}
