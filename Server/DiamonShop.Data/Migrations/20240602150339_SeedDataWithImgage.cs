using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiamonShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataWithImgage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductType",
                table: "Jewelrys");

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7549), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7543), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7541), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7524), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7545), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7818), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7845), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7850), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7816), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7826), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7839), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7824), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7847), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7836), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7834), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7842), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7831), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7829), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7812), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7821), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "DateCreated", "DateModified", "Description", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("01d6e4b7-147c-40e1-bbab-caafc2cdb564"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("0d3b34b6-986f-465e-bbec-a07f4e97e92d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m1.jpg?alt=media&token=1c3dcb9b-9ba2-49e4-a39b-c6c7fa428bc6" },
                    { new Guid("1ead01ce-ff4d-4e98-b954-fc614b781d4a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m1.jpg?alt=media&token=2144ca96-674c-454e-b5c4-9141e98af6d7" },
                    { new Guid("40840ea6-95ed-4f64-9e92-0e2a163963b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_2.jpg?alt=media&token=42dc5653-5240-4df1-9b39-c4d1975defd7" },
                    { new Guid("4725d10f-9f7a-406d-9a99-e9816009f2a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_1.jpg?alt=media&token=e313cc02-5436-487a-9a3b-71f4985fb733" },
                    { new Guid("4b785315-6914-48bc-8ad3-11d6304e30ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m2.jpg?alt=media&token=235c27dd-1417-46da-82ee-af820e415790" },
                    { new Guid("54a89527-51eb-4797-9604-4a02d0993304"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m1.jpg?alt=media&token=3788a61b-0bb2-40cd-a27f-da6d6c078939" },
                    { new Guid("5712b978-3147-4c48-9730-b61769af349a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m2.jpg?alt=media&token=001430c6-ef62-4db7-96cf-678ebcd6dea5" },
                    { new Guid("5b8c16dc-5f72-4cfd-ac6c-3426fc7deab3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_3.jpg?alt=media&token=801a85ce-434c-4eee-9652-3672d8bb4482" },
                    { new Guid("6a7d54b6-7ead-4ea0-b320-ac63cab2478d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m2.jpg?alt=media&token=33c0ae2b-4f6d-4864-879d-a1c08be6d412" },
                    { new Guid("70aa55c4-421d-4d37-a5af-a66655e3b25c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m2.jpg?alt=media&token=7f01ab19-e4e8-42ea-8278-2ce5b7e50872" },
                    { new Guid("89c4c931-af32-4d79-bcd5-bf1fce3b83b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_4.jpg?alt=media&token=f0761d38-c205-48d8-89fd-84039af48ddf" },
                    { new Guid("8e0f1b99-4099-41d2-94a9-5830ec86cfc0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m2.jpg?alt=media&token=f5167a68-4c7a-46cf-ad28-e352ab8481e5" },
                    { new Guid("a047c69a-3c28-48b3-a23c-cdbb1d53d6b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("c01985c5-ef13-45c5-a4b5-4d9871f4ecc5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m1.jpg?alt=media&token=5b52cbae-c5fd-4d97-8af8-5f2d5fb6df1b" },
                    { new Guid("c20d846c-a73b-4356-8736-a51273667bee"), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(8037), null, null, new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_1.jpg?alt=media&token=ac90a06a-e325-4d08-bf75-5d6078da28f4" },
                    { new Guid("cee707c5-bc81-444b-8cac-61f32838bec6"), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(8125), null, null, new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_2.jpg?alt=media&token=7a80ce7c-4073-46f7-a1e9-aa9d2196bdd6" },
                    { new Guid("cf56ed56-3092-4a82-a7a3-36fcd9b54766"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m1.jpg?alt=media&token=ce8862c1-380a-479e-a0e9-58634fa2d68a" },
                    { new Guid("d00856fd-e338-4705-b6a4-775318d46d22"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_3.jpg?alt=media&token=fc95d920-491f-4c8d-a50a-681673bb929d" },
                    { new Guid("d8e35448-9a3d-4a53-a634-1b63c9ea9c0e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_4.jpg?alt=media&token=164f4d10-12f3-442c-81d2-eed699c79bd5" },
                    { new Guid("df798e14-401b-4eca-a6c3-3134bd6a5ce9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_1.jpg?alt=media&token=42eda424-48f5-4586-a7e6-fda26c5659be" },
                    { new Guid("f063a3f7-c64a-4b2b-b60e-e6c68d59f2af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m2.jpg?alt=media&token=c7c568ef-cd9b-4889-9fc2-96e478177e97" },
                    { new Guid("fda3912d-1a06-489d-8f0b-8789935e309d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_1.jpg?alt=media&token=c8ef04f8-2a5e-4b64-a10e-b3693616f8a3" },
                    { new Guid("ff9e4708-53e7-4863-bd32-38c75b7332d2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m1.jpg?alt=media&token=ec5d2b70-753a-4485-a892-60c5c0938615" }
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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7644), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7710), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7720), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7668), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7700), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7673), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7641), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7688), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7651), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7723), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7690), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7718), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7719) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7664), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7649), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7671), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7661), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7678), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7659), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7684), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7666), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7708), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7682), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7656), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7654), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7638), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7695), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7646), new DateTime(2024, 6, 2, 22, 3, 39, 310, DateTimeKind.Local).AddTicks(7647) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("01d6e4b7-147c-40e1-bbab-caafc2cdb564"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("0d3b34b6-986f-465e-bbec-a07f4e97e92d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1ead01ce-ff4d-4e98-b954-fc614b781d4a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("40840ea6-95ed-4f64-9e92-0e2a163963b9"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4725d10f-9f7a-406d-9a99-e9816009f2a0"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4b785315-6914-48bc-8ad3-11d6304e30ee"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("54a89527-51eb-4797-9604-4a02d0993304"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("5712b978-3147-4c48-9730-b61769af349a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("5b8c16dc-5f72-4cfd-ac6c-3426fc7deab3"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6a7d54b6-7ead-4ea0-b320-ac63cab2478d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("70aa55c4-421d-4d37-a5af-a66655e3b25c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("89c4c931-af32-4d79-bcd5-bf1fce3b83b0"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("8e0f1b99-4099-41d2-94a9-5830ec86cfc0"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("a047c69a-3c28-48b3-a23c-cdbb1d53d6b5"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c01985c5-ef13-45c5-a4b5-4d9871f4ecc5"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c20d846c-a73b-4356-8736-a51273667bee"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("cee707c5-bc81-444b-8cac-61f32838bec6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("cf56ed56-3092-4a82-a7a3-36fcd9b54766"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d00856fd-e338-4705-b6a4-775318d46d22"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d8e35448-9a3d-4a53-a634-1b63c9ea9c0e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("df798e14-401b-4eca-a6c3-3134bd6a5ce9"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("f063a3f7-c64a-4b2b-b60e-e6c68d59f2af"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("fda3912d-1a06-489d-8f0b-8789935e309d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("ff9e4708-53e7-4863-bd32-38c75b7332d2"));

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

            migrationBuilder.AddColumn<string>(
                name: "ProductType",
                table: "Jewelrys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3793), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3794) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3788), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3785), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3768), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3791), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4034), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4062), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4068), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4032), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4042), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4057), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4039), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4065), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4053), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4050), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4060), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4047), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4045), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4028), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4037), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3877), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3934), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3938), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3902), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3930), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3907), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3874), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3923), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3923) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3884), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3941), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3925), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3936), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3898), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3898) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3882), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3905), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3895), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3916), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3916) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3893), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3920), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3900), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3932), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3932) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3918), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3890), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3887), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3871), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3927), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3879), new DateTime(2024, 6, 2, 21, 48, 33, 624, DateTimeKind.Local).AddTicks(3880) });
        }
    }
}
