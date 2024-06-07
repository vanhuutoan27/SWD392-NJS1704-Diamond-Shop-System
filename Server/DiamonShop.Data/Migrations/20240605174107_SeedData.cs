using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiamonShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "CategoryId", "CategoryImage", "DateCreated", "DateModified", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"), null, new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4826), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4827), null, "Earrings" },
                    { new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"), null, new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4821), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4821), null, "Ring" },
                    { new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"), null, new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4818), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4818), null, "Pendant" },
                    { new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), null, new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4797), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4811), "Kim Cuong vien nhap khau ", "Diamond" },
                    { new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"), null, new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4823), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4824), null, "Bracelet" }
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
                    { new Guid("005da949-dd83-438b-9ee9-aea012d87068"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4925), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4926), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4994), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4995), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5000), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5001), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4961), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4961), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4989), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4989), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4967), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4968), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4922), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4923), "Kinh cương tự nhiên 99%", "Kim Cương Viên", 21924560.0, 0 },
                    { new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4980), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4980), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4934), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4935), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5003), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5003), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4983), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4983), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), new Guid("131ff973-ac23-49d3-8880-04498fba1fa8"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4997), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4998), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4951), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4951), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4931), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4932), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4964), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4964), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4948), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4948), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"), new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4971), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4972), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4944), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4945), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4977), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4977), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("b9948c96-e456-471d-b523-159b7cf3242c"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4958), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4958), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), new Guid("c9522945-fec5-417f-90da-820cc66aaf6c"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4991), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4992), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), new Guid("420fcf35-560e-4fc9-86db-7ac3c5c7a38c"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4974), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4975), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4941), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4942), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4939), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4939), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 },
                    { new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4918), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4919), "Kinh cương tự nhiên 100%", "Kim Cương Viên", 535790600.0, 0 },
                    { new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), new Guid("419ca5be-f464-48ab-a7f4-b756673d28af"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4986), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4986), "Kinh cương tự nhiên 98%", "Jewelry", 32422800.0, 0 },
                    { new Guid("f376d66d-cf4a-4103-836f-43811290f18c"), new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4928), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(4929), "Kinh cương tự nhiên 98%", "Kim Cương Viên", 32422800.0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Diamonds",
                columns: new[] { "DiamondId", "Certification", "Clarity", "ColorLevel", "DateCreated", "DateModified", "Fluorescence", "Price", "ProductType", "QualityOfCut", "Shape", "Size", "SkuID", "Weight" },
                values: new object[,]
                {
                    { new Guid("005da949-dd83-438b-9ee9-aea012d87068"), "EGL", "I2", "F", new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5107), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5107), "Medium", 470000000.0, "Diamond", "Fair", "Round", 9.0999999999999996, "D003", 1.3999999999999999 },
                    { new Guid("27c26fa1-c62b-408b-99a3-bd36531b2a16"), "AGS", "VVS2", "J", new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5140), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5141), "Faint", 21000000.0, "Diamond", "Fair", "Pear", 4.9000000000000004, "D013", 2.5 },
                    { new Guid("48b3b08e-d266-4eec-b82c-b71c7303c446"), "IGI", "I1", "L", new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5146), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5147), "Strong", 292740000.0, "Diamond", "Good", "Pear", 7.2000000000000002, "D015", 0.90000000000000002 },
                    { new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"), "AGS", "VS2", "D", new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5103), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5104), "Faint", 83000000.0, "Diamond", "Poor", "Round", 6.2000000000000002, "D002", 2.7999999999999998 },
                    { new Guid("53edc0ad-98ad-41e9-9a1b-ada8950090cb"), "GIA", "SL2", "I", new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5118), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5119), "Strong", 15900000.0, "Diamond", "Very Good", "Emerald", 4.5999999999999996, "D006", 0.80000000000000004 },
                    { new Guid("751ea591-6934-4c48-a64b-bc64ef26c724"), "HRD", "VS1", "E", new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5134), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5135), "Strong", 668350000.0, "Diamond", "Excellent", "Cushion", 9.1999999999999993, "D011", 0.59999999999999998 },
                    { new Guid("76b4bb4a-3435-4876-af7f-ffb9b0301e00"), "IGI", "SL1", "J", new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5115), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5115), "Faint", 29400000.0, "Diamond", "Excellent", "Emerald", 5.2999999999999998, "D005", 3.1000000000000001 },
                    { new Guid("84b37cf4-2ae5-4a07-a5dc-e2703f93c129"), "EGL", "VVS1", "K", new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5143), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5144), "None", 105740000.0, "Diamond", "Poor", "Pear", 6.2999999999999998, "D014", 3.2000000000000002 },
                    { new Guid("87340bc6-a7cb-4a10-be79-77ae910348ef"), "GIA", "VVS2", "M", new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5131), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5132), "Medium", 26000000.0, "Diamond", "Excellent", "Cushion", 5.0999999999999996, "D010", 1.3 },
                    { new Guid("aa298dfb-004c-4008-b0a1-c143af1d15d5"), "IGI", "IF", "G", new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5128), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5128), "None", 61000000.0, "Diamond", "Poor", "Heart", 5.7999999999999998, "D009", 1.1899999999999999 },
                    { new Guid("b9948c96-e456-471d-b523-159b7cf3242c"), "HRD", "I1", "K", new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5137), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5138), "Strong", 392740000.0, "Diamond", "Very Good", "Cushion", 7.4000000000000004, "D012", 0.69999999999999996 },
                    { new Guid("c9807cfc-98b8-4b48-9ca8-fd4c44b6933c"), "EGL", "IF", "L", new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5124), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5125), "None", 268000000.0, "Diamond", "Fair", "Heart", 6.7999999999999998, "D008", 0.32000000000000001 },
                    { new Guid("d2c73200-1ae0-4066-9475-0bda2e220d57"), "AGS", "I2", "K", new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5121), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5122), "Medium", 615000000.0, "Diamond", "Good", "Heart", 8.6999999999999993, "D007", 0.40000000000000002 },
                    { new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"), "GIA", "IF", "E", new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5099), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5100), "None", 13500000.0, "Diamond", "Good", "Round", 4.4000000000000004, "D001", 0.31 },
                    { new Guid("f376d66d-cf4a-4103-836f-43811290f18c"), "HRD", "VVS1", "H", new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5110), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5111), "Strong", 364000000.0, "Diamond", "Very Good", "Emerald", 8.5, "D004", 2.1000000000000001 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "DateCreated", "DateModified", "Description", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("0c9f5d62-7173-47f1-8901-0f7db4662aa0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m2.jpg?alt=media&token=235c27dd-1417-46da-82ee-af820e415790" },
                    { new Guid("11ed27cf-789c-4030-8753-1e6e173cf1e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m1.jpg?alt=media&token=ec5d2b70-753a-4485-a892-60c5c0938615" },
                    { new Guid("1ac49f5e-b02e-42b6-a205-6c4ab11c062b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_4.jpg?alt=media&token=164f4d10-12f3-442c-81d2-eed699c79bd5" },
                    { new Guid("1ebbd530-3e8b-4cf3-96dc-e3b0a0997b0e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("2225cd32-d47f-4a03-8259-1c07edd53904"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m2.jpg?alt=media&token=001430c6-ef62-4db7-96cf-678ebcd6dea5" },
                    { new Guid("224f3ba1-039e-40ff-a445-743d47ca1e23"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra1%20m2.jpg?alt=media&token=7f01ab19-e4e8-42ea-8278-2ce5b7e50872" },
                    { new Guid("288361e4-7aa1-49f8-be2d-a840766e764e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_1.jpg?alt=media&token=e313cc02-5436-487a-9a3b-71f4985fb733" },
                    { new Guid("2a0672a0-fbf6-4863-8bc6-3ffb5a70c9ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m2.jpg?alt=media&token=c7c568ef-cd9b-4889-9fc2-96e478177e97" },
                    { new Guid("3ce84eaf-cfef-41d4-99d1-98ecc514c488"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ004_1.jpg?alt=media&token=c8ef04f8-2a5e-4b64-a10e-b3693616f8a3" },
                    { new Guid("4069353e-095b-461e-941a-5ae97839d3eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_1.jpg?alt=media&token=42eda424-48f5-4586-a7e6-fda26c5659be" },
                    { new Guid("52e4dd79-147a-4875-9408-c70231740589"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_4.jpg?alt=media&token=f0761d38-c205-48d8-89fd-84039af48ddf" },
                    { new Guid("5a7c66d8-af81-4327-8faf-0d2fcb0697ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_2.jpg?alt=media&token=42dc5653-5240-4df1-9b39-c4d1975defd7" },
                    { new Guid("92e7e2d1-64d2-4da3-8138-c200e8b287da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring1%20m1.jpg?alt=media&token=3788a61b-0bb2-40cd-a27f-da6d6c078939" },
                    { new Guid("9cfc4c4d-7453-4ed6-951b-3031c9712283"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m1.jpg?alt=media&token=5b52cbae-c5fd-4d97-8af8-5f2d5fb6df1b" },
                    { new Guid("a3e688c9-a8e1-423a-953b-b9c7580ff618"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring2%20m1.jpg?alt=media&token=1c3dcb9b-9ba2-49e4-a39b-c6c7fa428bc6" },
                    { new Guid("b142b4b4-836f-4a67-82fc-8913ff9852d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m2.jpg?alt=media&token=f5167a68-4c7a-46cf-ad28-e352ab8481e5" },
                    { new Guid("b1e19408-348a-427e-8937-1273ea69c979"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5377), null, null, new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_2.jpg?alt=media&token=7a80ce7c-4073-46f7-a1e9-aa9d2196bdd6" },
                    { new Guid("b36718a2-12a7-49ac-a569-585b096fae7b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ002_2.jpg?alt=media&token=a663022d-ce58-4774-a5ea-55089b414b4f" },
                    { new Guid("bc73b6ad-0661-47cb-8575-0a2966ddfaa0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ001_3.jpg?alt=media&token=fc95d920-491f-4c8d-a50a-681673bb929d" },
                    { new Guid("c20d846c-a73b-4356-8736-a51273667bee"), new DateTime(2024, 6, 6, 0, 41, 7, 48, DateTimeKind.Local).AddTicks(5343), null, null, new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_1.jpg?alt=media&token=ac90a06a-e325-4d08-bf75-5d6078da28f4" },
                    { new Guid("e2737961-1ee2-46a0-89a4-5cbb58a3eba2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fring3%20m1.jpg?alt=media&token=ce8862c1-380a-479e-a0e9-58634fa2d68a" },
                    { new Guid("ecae5412-59fe-4e0a-9b70-f336affd7c01"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra2%20m1.jpg?alt=media&token=2144ca96-674c-454e-b5c4-9141e98af6d7" },
                    { new Guid("f2f27a01-aa7c-4fed-a3c4-2df4aacec2a3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2FJ003_3.jpg?alt=media&token=801a85ce-434c-4eee-9652-3672d8bb4482" },
                    { new Guid("fe9dc59f-f3d8-4988-bd44-94063845baee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Products%2FJewelry%2Fbra3%20m2.jpg?alt=media&token=33c0ae2b-4f6d-4864-879d-a1c08be6d412" }
                });

            migrationBuilder.InsertData(
                table: "Jewelrys",
                columns: new[] { "JewelryId", "GoldKarat", "GoldType", "GoldWeight", "MainStoneSize", "Name", "Price", "ProductType", "SkuID", "StoneWeight", "sideStoneQuantity", "sideStoneType" },
                values: new object[,]
                {
                    { new Guid("1876fa93-1502-4d84-93ae-5ba6301d63cb"), "18K", "White gold", 5.9000000000000004, "Round 6.1ly", "18K DIAMOND BRACELET", 139800000.0, "Jewelry", "J009", 2.7000000000000002, 57, "Diamond" },
                    { new Guid("1cc86444-85b6-4cd7-b002-afe58ca36a39"), "18K", "White gold", 1.0800000000000001, "Round 5.3ly", "18K DIAMOND ERRINGS", 47239000.0, "Jewelry", "J011", 0.10000000000000001, 60, "Diamond" },
                    { new Guid("361c08c6-49c7-4da0-96c3-9062acd03bff"), "18K", "White gold", 6.5999999999999996, "Round 5.4ly", "18K DIAMOND BRACELET", 135371000.0, "Jewelry", "J007", 2.2000000000000002, 43, "Diamond" },
                    { new Guid("4fd47f59-6149-48c2-b1ad-e454438d08c3"), "18K", "White gold", 1.05, "Round 4.5ly", "18K DIAMOND RING", 38589000.0, "Jewelry", "J004", 1.0700000000000001, 38, "Diamond" },
                    { new Guid("5d411445-ba01-46d2-92a4-c690f1e19db4"), "18K", "White gold", 1.0700000000000001, "Round 4.9ly", "18K DIAMOND ERRINGS", 44650000.0, "Jewelry", "J012", 0.029999999999999999, 23, "Diamond" },
                    { new Guid("6abb1f7d-1bab-4405-8f72-a817c2fe9b05"), "18K", "White gold", 1.0900000000000001, "Round 4.0ly", "18K DIAMOND RING", 37430000.0, "Jewelry", "J005", 2.0, 63, "Diamond" },
                    { new Guid("734aab01-8668-4e5c-8afb-473b05fc52c0"), "18K", "White gold", 1.04, "Round 5ly", "18K DIAMOND ERRINGS", 31317000.0, "Jewelry", "J010", 0.040000000000000001, 15, "Diamond" },
                    { new Guid("9f3519c6-1df4-4125-bbef-8e7825425dcd"), "18K", "White gold", 0.53000000000000003, "Round 5ly", "18K DIAMOND PENDANT", 28300000.0, "Jewelry", "J001", 1.1000000000000001, 23, "Diamond" },
                    { new Guid("af32b397-0dc4-46fa-aa7f-eb31bffd2821"), "18K", "White gold", 0.57999999999999996, "Round 6.3ly", "18K DIAMOND PENDANT", 33450000.0, "Jewelry", "J003", 1.2, 20, "Diamond" },
                    { new Guid("bce4345d-d1cb-4d01-b904-be38fcb9caca"), "18K", "White gold", 7.0999999999999996, "Round 6.3ly", "18K DIAMOND BRACELET", 148239000.0, "Jewelry", "J008", 2.7999999999999998, 92, "Diamond" },
                    { new Guid("c2bc12a6-e878-4da0-9b70-656cc94f3316"), "18K", "White gold", 0.60999999999999999, "Round 5.1ly", "18K DIAMOND PENDANT", 31200000.0, "Jewelry", "J002", 1.1200000000000001, 27, "Diamond" },
                    { new Guid("e8447232-f062-423c-ac95-eaad6fc8d8b1"), "18K", "White gold", 1.1699999999999999, "Round 5.2ly", "18K DIAMOND RING", 41246000.0, "Jewelry", "J006", 1.1000000000000001, 2, "Diamond" }
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
                keyValue: new Guid("0c9f5d62-7173-47f1-8901-0f7db4662aa0"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("11ed27cf-789c-4030-8753-1e6e173cf1e7"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1ac49f5e-b02e-42b6-a205-6c4ab11c062b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1ebbd530-3e8b-4cf3-96dc-e3b0a0997b0e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("2225cd32-d47f-4a03-8259-1c07edd53904"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("224f3ba1-039e-40ff-a445-743d47ca1e23"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("288361e4-7aa1-49f8-be2d-a840766e764e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("2a0672a0-fbf6-4863-8bc6-3ffb5a70c9ce"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("3ce84eaf-cfef-41d4-99d1-98ecc514c488"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4069353e-095b-461e-941a-5ae97839d3eb"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("52e4dd79-147a-4875-9408-c70231740589"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("5a7c66d8-af81-4327-8faf-0d2fcb0697ef"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("92e7e2d1-64d2-4da3-8138-c200e8b287da"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("9cfc4c4d-7453-4ed6-951b-3031c9712283"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("a3e688c9-a8e1-423a-953b-b9c7580ff618"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("b142b4b4-836f-4a67-82fc-8913ff9852d4"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("b1e19408-348a-427e-8937-1273ea69c979"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("b36718a2-12a7-49ac-a569-585b096fae7b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("bc73b6ad-0661-47cb-8575-0a2966ddfaa0"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c20d846c-a73b-4356-8736-a51273667bee"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("e2737961-1ee2-46a0-89a4-5cbb58a3eba2"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("ecae5412-59fe-4e0a-9b70-f336affd7c01"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("f2f27a01-aa7c-4fed-a3c4-2df4aacec2a3"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("fe9dc59f-f3d8-4988-bd44-94063845baee"));

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
        }
    }
}
