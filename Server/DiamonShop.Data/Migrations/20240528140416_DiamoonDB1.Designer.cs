﻿// <auto-generated />
using System;
using DiamonShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiamonShop.Data.Migrations
{
    [DbContext(typeof(DiamondContext))]
    [Migration("20240528140416_DiamoonDB1")]
    partial class DiamoonDB1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DiamonShop.Core.Domain.Content.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categorys");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                            DateCreated = new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(7730),
                            DateModified = new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(7742),
                            Description = "Kim Cuong vien nhap khau ",
                            Name = "Kim Cương Viên"
                        });
                });

            modelBuilder.Entity("DiamonShop.Core.Domain.Content.Diamond", b =>
                {
                    b.Property<Guid>("DiamondId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Certification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clarity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fluorescence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("QualityOfCut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shape")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Size")
                        .HasColumnType("float");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("DiamondId");

                    b.ToTable("Diamonds");

                    b.HasData(
                        new
                        {
                            DiamondId = new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                            Certification = "GIA",
                            Clarity = "VVS2",
                            ColorLevel = "F",
                            DateCreated = new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(8097),
                            DateModified = new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(8099),
                            Fluorescence = "MEDIUM",
                            Price = 535790600.0,
                            QualityOfCut = "Excellent",
                            Shape = "Pear",
                            Size = 4.4000000000000004,
                            Weight = 1.5
                        },
                        new
                        {
                            DiamondId = new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                            Certification = "GIA",
                            Clarity = "VS3",
                            ColorLevel = "D",
                            DateCreated = new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(8104),
                            DateModified = new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(8104),
                            Fluorescence = "MEDIUM",
                            Price = 21924560.0,
                            QualityOfCut = "Excellent",
                            Shape = "Round",
                            Size = 4.4000000000000004,
                            Weight = 2.5
                        },
                        new
                        {
                            DiamondId = new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                            Certification = "GIA",
                            Clarity = "IF",
                            ColorLevel = "D",
                            DateCreated = new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(8107),
                            DateModified = new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(8108),
                            Fluorescence = "MEDIUM",
                            Price = 32422800.0,
                            QualityOfCut = "Excellent",
                            Shape = "Round",
                            Size = 4.2999999999999998,
                            Weight = 2.7000000000000002
                        });
                });

            modelBuilder.Entity("DiamonShop.Core.Domain.Content.Image", b =>
                {
                    b.Property<Guid>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("DiamonShop.Core.Domain.Content.Inventory", b =>
                {
                    b.Property<Guid>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("InventoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("Inventorys");
                });

            modelBuilder.Entity("DiamonShop.Core.Domain.Content.Jewelry", b =>
                {
                    b.Property<Guid>("JewelryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GoldKarat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GoldType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GoldWeight")
                        .HasColumnType("float");

                    b.Property<string>("MainStoneSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("StoneWeight")
                        .HasColumnType("float");

                    b.Property<int>("sideStoneQuantity")
                        .HasColumnType("int");

                    b.Property<string>("sideStoneType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JewelryId");

                    b.ToTable("Jewelrys");
                });

            modelBuilder.Entity("DiamonShop.Core.Domain.Content.Order", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DiamonShop.Core.Domain.Content.OrderItem", b =>
                {
                    b.Property<Guid>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("DiamonShop.Core.Domain.Content.Payment", b =>
                {
                    b.Property<Guid>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("OrderId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("DiamonShop.Core.Domain.Content.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("e655174b-f444-4ab8-baa8-71ac382d73df"),
                            CategoryId = new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                            DateCreated = new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(7858),
                            DateModified = new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(7859),
                            Description = "Kinh cương tự nhiên 100%",
                            Name = "Kim Cương Viên",
                            Price = 535790600.0,
                            Status = 0
                        },
                        new
                        {
                            ProductId = new Guid("4f5cbe8a-a04a-484f-978d-4b26d2979063"),
                            CategoryId = new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                            DateCreated = new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(7863),
                            DateModified = new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(7865),
                            Description = "Kinh cương tự nhiên 99%",
                            Name = "Kim Cương Viên",
                            Price = 21924560.0,
                            Status = 0
                        },
                        new
                        {
                            ProductId = new Guid("005da949-dd83-438b-9ee9-aea012d87068"),
                            CategoryId = new Guid("816f2393-683e-428c-a4bb-2ba6e2e3f791"),
                            DateCreated = new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(7868),
                            DateModified = new DateTime(2024, 5, 28, 21, 4, 15, 545, DateTimeKind.Local).AddTicks(7869),
                            Description = "Kinh cương tự nhiên 98%",
                            Name = "Kim Cương Viên",
                            Price = 32422800.0,
                            Status = 0
                        });
                });

            modelBuilder.Entity("DiamonShop.Core.Domain.Identity.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"),
                            DisplayName = "Khách Hàng",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"),
                            DisplayName = "Quản Lí",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = new Guid("ab8e4032-2d95-45cc-89c1-c039e9e8bc39"),
                            DisplayName = "Nhân Viên Giao Hàng",
                            Name = "DeliveryStaff",
                            NormalizedName = "DELIVERYSTAFF"
                        },
                        new
                        {
                            Id = new Guid("1401744d-0421-41eb-b9d6-f888aaccca91"),
                            DisplayName = "Nhân Viên Giao Hàng",
                            Name = "SaleStaff",
                            NormalizedName = "DELIVERYSTAFF"
                        });
                });

            modelBuilder.Entity("DiamonShop.Core.Domain.Identity.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLoginDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("RoyaltyAmountPerPost")
                        .HasColumnType("float");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("VipExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("VipStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId", "UserId");

                    b.ToTable("AppUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens", (string)null);
                });

            modelBuilder.Entity("DiamonShop.Core.Domain.Content.Diamond", b =>
                {
                    b.HasOne("DiamonShop.Core.Domain.Content.Product", "Product")
                        .WithOne("Diamond")
                        .HasForeignKey("DiamonShop.Core.Domain.Content.Diamond", "DiamondId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DiamonShop.Core.Domain.Content.Image", b =>
                {
                    b.HasOne("DiamonShop.Core.Domain.Content.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DiamonShop.Core.Domain.Content.Inventory", b =>
                {
                    b.HasOne("DiamonShop.Core.Domain.Content.Product", "Product")
                        .WithMany("Inventorys")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DiamonShop.Core.Domain.Content.Jewelry", b =>
                {
                    b.HasOne("DiamonShop.Core.Domain.Content.Product", "Product")
                        .WithOne("Jewelry")
                        .HasForeignKey("DiamonShop.Core.Domain.Content.Jewelry", "JewelryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DiamonShop.Core.Domain.Content.OrderItem", b =>
                {
                    b.HasOne("DiamonShop.Core.Domain.Content.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiamonShop.Core.Domain.Content.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DiamonShop.Core.Domain.Content.Payment", b =>
                {
                    b.HasOne("DiamonShop.Core.Domain.Content.Order", "Order")
                        .WithMany("Payments")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("DiamonShop.Core.Domain.Content.Product", b =>
                {
                    b.HasOne("DiamonShop.Core.Domain.Content.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DiamonShop.Core.Domain.Content.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DiamonShop.Core.Domain.Content.Order", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("DiamonShop.Core.Domain.Content.Product", b =>
                {
                    b.Navigation("Diamond")
                        .IsRequired();

                    b.Navigation("Images");

                    b.Navigation("Inventorys");

                    b.Navigation("Jewelry")
                        .IsRequired();

                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
