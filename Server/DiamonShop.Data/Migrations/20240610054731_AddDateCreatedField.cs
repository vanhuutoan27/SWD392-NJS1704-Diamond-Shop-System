using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiamonShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDateCreatedField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("0cbed5e2-5cd1-4d73-af72-b976e54ea7f7"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("113e256a-43c4-460b-bb77-d93546d2b395"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("2113b4b9-e0ed-439b-874e-1c1bf1e385e2"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("2de9f105-0b6e-409c-b502-c344089fcf86"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("38b09fa0-969f-42cc-80f0-58699e2030ab"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("41e23a43-884d-4bcf-aac0-530dfe83d90c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4b033141-3560-47e7-9a65-683c895ee9b7"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4c3cf25b-cf84-49fc-8f76-5a08d6fdf739"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4c9410dd-c49e-473a-a8ab-580ec7259019"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("5b174d04-7bb2-4cd1-a255-7ee6d22fc830"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("612edaa3-e864-45d2-bb02-872caacebd5d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("a177f11a-e135-49c9-af7a-f09e4b111ad0"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("a5cc5448-1490-4f10-94cb-838360321bec"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("ad6f7e03-7d36-4a80-b1f0-cd9fa8f3735c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("aeff1391-5b29-434b-bc42-3bf648a58185"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("af78e943-01dd-44ae-b863-cc07e0569823"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("b0247dd8-e276-4110-a615-d26f943c23c8"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("b9cf6191-59e5-48ef-8a7f-edd1e37ca91e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("cc94e69a-ed43-4b7f-b127-eb894ec21310"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d13b79a7-ce04-4426-a253-d4e5ac223d6f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d4d8861e-d588-4667-83a4-d7d01d1e53fe"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d8218aae-c430-47c2-a4d9-bcf08fd27b61"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("e2dbf1b2-5783-47ad-a706-984517e5ea64"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Jewelrys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "Jewelrys",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2237), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2233), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2223), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2207), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2234), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2460), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2485), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2498), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2458), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2468), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2468) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2480), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2465), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2487), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2478), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2475), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2482), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2473), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2470), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2454), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2463), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c20d846c-a73b-4356-8736-a51273667bee"),
                column: "DateCreated",
                value: new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "DateCreated", "DateModified", "Description", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("09a7bd85-b700-4409-98c4-ee5428d80667"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m1.jpg?alt=media&token=1c3dcb9b-9ba2-49e4-a39b-c6c7fa428bc6" },
                    { new Guid("1199a418-b68f-4597-bf9b-cb770759772f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m2.jpg?alt=media&token=33c0ae2b-4f6d-4864-879d-a1c08be6d412" },
                    { new Guid("1317491e-6e39-4e97-94c4-8985571ba043"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m1.jpg?alt=media&token=ec5d2b70-753a-4485-a892-60c5c0938615" },
                    { new Guid("1a089008-1ef8-45ee-a647-f2ad57fb6ab2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m2.jpg?alt=media&token=f5167a68-4c7a-46cf-ad28-e352ab8481e5" },
                    { new Guid("1cccc592-2386-440b-b525-0d950ce7405e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m2.jpg?alt=media&token=235c27dd-1417-46da-82ee-af820e415790" },
                    { new Guid("1f3a48e6-430e-4ed1-af98-cdb292c823ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_1.jpg?alt=media&token=e313cc02-5436-487a-9a3b-71f4985fb733" },
                    { new Guid("2277932d-ef01-4cd2-a2b5-4696af94af4a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("26265a30-48a8-495f-9bd5-5d1de032518b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m2.jpg?alt=media&token=001430c6-ef62-4db7-96cf-678ebcd6dea5" },
                    { new Guid("34a2534e-bfde-4566-96b2-507179d6b50f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m1.jpg?alt=media&token=ce8862c1-380a-479e-a0e9-58634fa2d68a" },
                    { new Guid("4bb7728c-b15c-4316-ad1e-6f92f0695958"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m1.jpg?alt=media&token=5b52cbae-c5fd-4d97-8af8-5f2d5fb6df1b" },
                    { new Guid("555e5078-d390-4cab-b127-81fe384244a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_1.jpg?alt=media&token=42eda424-48f5-4586-a7e6-fda26c5659be" },
                    { new Guid("5b6b2190-1769-4805-a285-ca9da73ec785"), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2715), null, null, new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_2.jpg?alt=media&token=7a80ce7c-4073-46f7-a1e9-aa9d2196bdd6" },
                    { new Guid("6f5ac7eb-297d-4a60-a588-4dc01c801533"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_1.jpg?alt=media&token=c8ef04f8-2a5e-4b64-a10e-b3693616f8a3" },
                    { new Guid("71bcfd2b-cc86-4bc7-9935-e91796b3835e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_4.jpg?alt=media&token=f0761d38-c205-48d8-89fd-84039af48ddf" },
                    { new Guid("72697767-bc7a-43ec-bc06-584cfb96f535"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m2.jpg?alt=media&token=7f01ab19-e4e8-42ea-8278-2ce5b7e50872" },
                    { new Guid("737c7e14-f3b0-42ea-bc91-8c05c819895a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m1.jpg?alt=media&token=3788a61b-0bb2-40cd-a27f-da6d6c078939" },
                    { new Guid("888f7f39-f29d-4126-9312-8d6699657dac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_3.jpg?alt=media&token=801a85ce-434c-4eee-9652-3672d8bb4482" },
                    { new Guid("a1ea0747-9b03-4458-990e-2c0f2e4635dd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m2.jpg?alt=media&token=c7c568ef-cd9b-4889-9fc2-96e478177e97" },
                    { new Guid("b9a18ff7-3a00-4a40-9599-f6fef5a1b07d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_4.jpg?alt=media&token=164f4d10-12f3-442c-81d2-eed699c79bd5" },
                    { new Guid("be502b7d-4ac8-4672-af22-608343bfc206"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_3.jpg?alt=media&token=fc95d920-491f-4c8d-a50a-681673bb929d" },
                    { new Guid("da618071-5d73-4ca4-b155-4366a440e50a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m1.jpg?alt=media&token=2144ca96-674c-454e-b5c4-9141e98af6d7" },
                    { new Guid("e5749463-e232-43d2-a827-da6140eb6ce6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("eebde885-72f9-4bf7-afee-713c02df47c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_2.jpg?alt=media&token=42dc5653-5240-4df1-9b39-c4d1975defd7" }
                });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2608), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2613), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2603), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2603) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2595), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2615), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2598), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2610), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2584), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2593), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2605), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2589), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "Jewelrys",
                keyColumn: "JewelryId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2600), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2316), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2368), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2372), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2341), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2363), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2345), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2313), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2357), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2324), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2374), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2359), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2370), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2337), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2321), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2343), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2334), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2350), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2332), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2355), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2339), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2366), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2353), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2329), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2327), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2310), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2361), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2318), new DateTime(2024, 6, 10, 12, 47, 30, 954, DateTimeKind.Local).AddTicks(2319) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("09a7bd85-b700-4409-98c4-ee5428d80667"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1199a418-b68f-4597-bf9b-cb770759772f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1317491e-6e39-4e97-94c4-8985571ba043"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1a089008-1ef8-45ee-a647-f2ad57fb6ab2"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1cccc592-2386-440b-b525-0d950ce7405e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1f3a48e6-430e-4ed1-af98-cdb292c823ee"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("2277932d-ef01-4cd2-a2b5-4696af94af4a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("26265a30-48a8-495f-9bd5-5d1de032518b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("34a2534e-bfde-4566-96b2-507179d6b50f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4bb7728c-b15c-4316-ad1e-6f92f0695958"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("555e5078-d390-4cab-b127-81fe384244a7"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("5b6b2190-1769-4805-a285-ca9da73ec785"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6f5ac7eb-297d-4a60-a588-4dc01c801533"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("71bcfd2b-cc86-4bc7-9935-e91796b3835e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("72697767-bc7a-43ec-bc06-584cfb96f535"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("737c7e14-f3b0-42ea-bc91-8c05c819895a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("888f7f39-f29d-4126-9312-8d6699657dac"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("a1ea0747-9b03-4458-990e-2c0f2e4635dd"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("b9a18ff7-3a00-4a40-9599-f6fef5a1b07d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("be502b7d-4ac8-4672-af22-608343bfc206"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("da618071-5d73-4ca4-b155-4366a440e50a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("e5749463-e232-43d2-a827-da6140eb6ce6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("eebde885-72f9-4bf7-afee-713c02df47c7"));

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Jewelrys");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "Jewelrys");

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2748), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2744), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2742), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2723), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "CategoryId",
                keyValue: new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2746), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3002), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3033), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3038), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3000), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3015), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3028), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3008), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3036), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3025), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3022), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3030), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3020), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3018), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2997), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "Diamonds",
                keyColumn: "DiamondId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3005), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c20d846c-a73b-4356-8736-a51273667bee"),
                column: "DateCreated",
                value: new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "DateCreated", "DateModified", "Description", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("0cbed5e2-5cd1-4d73-af72-b976e54ea7f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m2.jpg?alt=media&token=f5167a68-4c7a-46cf-ad28-e352ab8481e5" },
                    { new Guid("113e256a-43c4-460b-bb77-d93546d2b395"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("2113b4b9-e0ed-439b-874e-1c1bf1e385e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m1.jpg?alt=media&token=5b52cbae-c5fd-4d97-8af8-5f2d5fb6df1b" },
                    { new Guid("2de9f105-0b6e-409c-b502-c344089fcf86"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_1.jpg?alt=media&token=42eda424-48f5-4586-a7e6-fda26c5659be" },
                    { new Guid("38b09fa0-969f-42cc-80f0-58699e2030ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m2.jpg?alt=media&token=33c0ae2b-4f6d-4864-879d-a1c08be6d412" },
                    { new Guid("41e23a43-884d-4bcf-aac0-530dfe83d90c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_3.jpg?alt=media&token=801a85ce-434c-4eee-9652-3672d8bb4482" },
                    { new Guid("4b033141-3560-47e7-9a65-683c895ee9b7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m1.jpg?alt=media&token=ce8862c1-380a-479e-a0e9-58634fa2d68a" },
                    { new Guid("4c3cf25b-cf84-49fc-8f76-5a08d6fdf739"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_3.jpg?alt=media&token=fc95d920-491f-4c8d-a50a-681673bb929d" },
                    { new Guid("4c9410dd-c49e-473a-a8ab-580ec7259019"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m1.jpg?alt=media&token=3788a61b-0bb2-40cd-a27f-da6d6c078939" },
                    { new Guid("5b174d04-7bb2-4cd1-a255-7ee6d22fc830"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m2.jpg?alt=media&token=c7c568ef-cd9b-4889-9fc2-96e478177e97" },
                    { new Guid("612edaa3-e864-45d2-bb02-872caacebd5d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_4.jpg?alt=media&token=f0761d38-c205-48d8-89fd-84039af48ddf" },
                    { new Guid("a177f11a-e135-49c9-af7a-f09e4b111ad0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_2.jpg?alt=media&token=42dc5653-5240-4df1-9b39-c4d1975defd7" },
                    { new Guid("a5cc5448-1490-4f10-94cb-838360321bec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m2.jpg?alt=media&token=001430c6-ef62-4db7-96cf-678ebcd6dea5" },
                    { new Guid("ad6f7e03-7d36-4a80-b1f0-cd9fa8f3735c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m1.jpg?alt=media&token=ec5d2b70-753a-4485-a892-60c5c0938615" },
                    { new Guid("aeff1391-5b29-434b-bc42-3bf648a58185"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_4.jpg?alt=media&token=164f4d10-12f3-442c-81d2-eed699c79bd5" },
                    { new Guid("af78e943-01dd-44ae-b863-cc07e0569823"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("b0247dd8-e276-4110-a615-d26f943c23c8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_1.jpg?alt=media&token=e313cc02-5436-487a-9a3b-71f4985fb733" },
                    { new Guid("b9cf6191-59e5-48ef-8a7f-edd1e37ca91e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m1.jpg?alt=media&token=1c3dcb9b-9ba2-49e4-a39b-c6c7fa428bc6" },
                    { new Guid("cc94e69a-ed43-4b7f-b127-eb894ec21310"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m1.jpg?alt=media&token=2144ca96-674c-454e-b5c4-9141e98af6d7" },
                    { new Guid("d13b79a7-ce04-4426-a253-d4e5ac223d6f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_1.jpg?alt=media&token=c8ef04f8-2a5e-4b64-a10e-b3693616f8a3" },
                    { new Guid("d4d8861e-d588-4667-83a4-d7d01d1e53fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m2.jpg?alt=media&token=235c27dd-1417-46da-82ee-af820e415790" },
                    { new Guid("d8218aae-c430-47c2-a4d9-bcf08fd27b61"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m2.jpg?alt=media&token=7f01ab19-e4e8-42ea-8278-2ce5b7e50872" },
                    { new Guid("e2dbf1b2-5783-47ad-a706-984517e5ea64"), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(3305), null, null, new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_2.jpg?alt=media&token=7a80ce7c-4073-46f7-a1e9-aa9d2196bdd6" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2843), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2892), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2896), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2867), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2887), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2871), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2840), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2881), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2849), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2898), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2883), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2894), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2862), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2847), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2869), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2859), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2874), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2857), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2879), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b9948c96-e456-471d-b523-159b7cf3242c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2864), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2890), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2877), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2854), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2852), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2837), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2885), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f376d66d-cf4a-4103-836f-43811290f18c"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2845), new DateTime(2024, 6, 6, 16, 0, 43, 939, DateTimeKind.Local).AddTicks(2845) });
        }
    }
}
