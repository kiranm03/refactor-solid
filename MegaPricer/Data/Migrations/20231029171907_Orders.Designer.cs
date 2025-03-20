﻿// <auto-generated />
using System;
using MegaPricer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MegaPricer.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231029171907_Orders")]
    partial class Orders
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("MegaPricer.Data.Cabinet", b =>
                {
                    b.Property<int>("CabinetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CabinetOrder")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Color")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Depth")
                        .HasColumnType("REAL");

                    b.Property<float>("Height")
                        .HasColumnType("REAL");

                    b.Property<float>("LeftOffset")
                        .HasColumnType("REAL");

                    b.Property<string>("SKU")
                        .HasColumnType("TEXT");

                    b.Property<float>("TopOffset")
                        .HasColumnType("REAL");

                    b.Property<int>("WallId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Width")
                        .HasColumnType("REAL");

                    b.HasKey("CabinetId");

                    b.HasIndex("WallId");

                    b.ToTable("Cabinets");
                });

            modelBuilder.Entity("MegaPricer.Data.Feature", b =>
                {
                    b.Property<int>("FeatureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CabinetId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Color")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Depth")
                        .HasColumnType("REAL");

                    b.Property<int>("FeatureOrder")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Height")
                        .HasColumnType("REAL");

                    b.Property<bool>("IsDoor")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SKU")
                        .HasColumnType("TEXT");

                    b.Property<float>("Width")
                        .HasColumnType("REAL");

                    b.HasKey("FeatureId");

                    b.HasIndex("CabinetId");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("MegaPricer.Data.Kitchen", b =>
                {
                    b.Property<int>("KitchenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("BaseDepth")
                        .HasColumnType("REAL");

                    b.Property<float>("BaseHeight")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("KitchenId");

                    b.ToTable("Kitchens");
                });

            modelBuilder.Entity("MegaPricer.Data.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("KitchenId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderStatus")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrderType")
                        .HasColumnType("TEXT");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MegaPricer.Data.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("BasePrice")
                        .HasColumnType("REAL");

                    b.Property<float>("Markup")
                        .HasColumnType("REAL");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SKU")
                        .HasColumnType("TEXT");

                    b.Property<float>("UserMarkup")
                        .HasColumnType("REAL");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("MegaPricer.Data.PricingColor", b =>
                {
                    b.Property<int>("PricingColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("ColorPerSquareFoot")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<float>("PercentMarkup")
                        .HasColumnType("REAL");

                    b.Property<float>("WholesalePrice")
                        .HasColumnType("REAL");

                    b.HasKey("PricingColorId");

                    b.ToTable("PricingColors");
                });

            modelBuilder.Entity("MegaPricer.Data.PricingSku", b =>
                {
                    b.Property<int>("PricingSkuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("SKU")
                        .HasColumnType("TEXT");

                    b.Property<float>("WholesalePrice")
                        .HasColumnType("REAL");

                    b.HasKey("PricingSkuId");

                    b.ToTable("PricingSkus");
                });

            modelBuilder.Entity("MegaPricer.Data.UserMarkup", b =>
                {
                    b.Property<int>("UserMarkupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MarkupPercent")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("UseCustomPricing")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("UserMarkupId");

                    b.ToTable("UserMarkups");
                });

            modelBuilder.Entity("MegaPricer.Data.Wall", b =>
                {
                    b.Property<int>("WallId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BackingColor")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CabinetColor")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Height")
                        .HasColumnType("REAL");

                    b.Property<bool>("IsIsland")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KitchenId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("VertColor")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WallOrder")
                        .HasColumnType("INTEGER");

                    b.HasKey("WallId");

                    b.HasIndex("KitchenId");

                    b.ToTable("Walls");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "aab4fac1-c546-41de-aebc-a14da6895711",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "a7b013f0-5201-4317-abd8-c211f91b7330",
                            Name = "Sales",
                            NormalizedName = "SALES"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "b74ddd14-6340-4840-95c2-abcdef4843e5",
                            RoleId = "aab4fac1-c546-41de-aebc-a14da6895711"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MegaPricer.Data.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("CompanyShortName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PricingOff")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("AppUser");

                    b.HasData(
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-abcdef4843e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d9e55c51-5c33-4d00-b4a1-c65c72d2556f",
                            Email = "admin@test.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@TEST.COM",
                            NormalizedUserName = "ADMIN@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEJakOqI7SK737L9BHVnyUSN1fiY3n0gaba4HMR+Xn/+shQ08SPLVOEWlK9oId/jJdw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b2194aef-0f4b-4323-9b20-10e91f2c6e4d",
                            TwoFactorEnabled = false,
                            UserName = "admin@test.com",
                            CompanyShortName = "ACME",
                            PricingOff = "N"
                        });
                });

            modelBuilder.Entity("MegaPricer.Data.Cabinet", b =>
                {
                    b.HasOne("MegaPricer.Data.Wall", null)
                        .WithMany("Cabinets")
                        .HasForeignKey("WallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MegaPricer.Data.Feature", b =>
                {
                    b.HasOne("MegaPricer.Data.Cabinet", null)
                        .WithMany("Features")
                        .HasForeignKey("CabinetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MegaPricer.Data.OrderItem", b =>
                {
                    b.HasOne("MegaPricer.Data.Order", null)
                        .WithMany("orderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MegaPricer.Data.Wall", b =>
                {
                    b.HasOne("MegaPricer.Data.Kitchen", null)
                        .WithMany("Walls")
                        .HasForeignKey("KitchenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MegaPricer.Data.Cabinet", b =>
                {
                    b.Navigation("Features");
                });

            modelBuilder.Entity("MegaPricer.Data.Kitchen", b =>
                {
                    b.Navigation("Walls");
                });

            modelBuilder.Entity("MegaPricer.Data.Order", b =>
                {
                    b.Navigation("orderItems");
                });

            modelBuilder.Entity("MegaPricer.Data.Wall", b =>
                {
                    b.Navigation("Cabinets");
                });
#pragma warning restore 612, 618
        }
    }
}
