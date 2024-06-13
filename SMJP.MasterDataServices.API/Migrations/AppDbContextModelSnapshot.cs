﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMJP.MasterDataServices.API.Data;

#nullable disable

namespace SMJP.MasterDataServices.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.3.24172.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SMJP.MasterDataServices.API.Models.Companies", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyID"));

                    b.Property<string>("CompanyAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CompanyPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProvinceID")
                        .HasColumnType("int");

                    b.HasKey("CompanyID");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            CompanyID = 1,
                            CompanyAddress = "Jl. M.H.Thamrin No.10",
                            CompanyEmail = "pertamina@example.com",
                            CompanyName = "Pertamina",
                            CompanyPhone = "1234567890",
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2024, 6, 6, 3, 15, 53, 763, DateTimeKind.Utc).AddTicks(7120),
                            Latitude = "40.7128",
                            LogoUrl = "https://pertamina.com/logo1.png",
                            Longitude = "-74.0060",
                            ModifiedBy = 1,
                            ModifiedDate = new DateTime(2024, 6, 6, 3, 15, 53, 763, DateTimeKind.Utc).AddTicks(7121),
                            ProvinceID = 1
                        });
                });

            modelBuilder.Entity("SMJP.MasterDataServices.API.Models.Dto.Users", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<DateTime>("ActiveDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyID")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByIpAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<int>("IsAdmin")
                        .HasColumnType("int");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("RegionID")
                        .HasColumnType("int");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<int>("SiteID")
                        .HasColumnType("int");

                    b.Property<int>("SyncTime")
                        .HasColumnType("int");

                    b.Property<string>("UserCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserID");

                    b.HasIndex("CompanyID");

                    b.HasIndex("RegionID");

                    b.HasIndex("SiteID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            ActiveDate = new DateTime(2024, 6, 6, 3, 15, 53, 763, DateTimeKind.Utc).AddTicks(6666),
                            AvatarUrl = "https://example.com/avatar1.png",
                            CompanyID = 1,
                            CreatedBy = 1,
                            CreatedByIpAddress = "127.0.0.1",
                            CreatedDate = new DateTime(2024, 6, 6, 3, 15, 53, 763, DateTimeKind.Utc).AddTicks(6675),
                            Email = "johndoe@example.com",
                            FullName = "John Doe",
                            IsActive = 1,
                            IsAdmin = 0,
                            ModifiedBy = 1,
                            ModifiedDate = new DateTime(2024, 6, 6, 3, 15, 53, 763, DateTimeKind.Utc).AddTicks(6676),
                            Password = "hashed_password",
                            Phone = "1234567890",
                            RegionID = 1,
                            RoleID = 1,
                            SiteID = 1,
                            SyncTime = 1,
                            UserCode = "USER001",
                            Username = "johndoe"
                        });
                });

            modelBuilder.Entity("SMJP.MasterDataServices.API.Models.Regions", b =>
                {
                    b.Property<int>("RegionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegionID"));

                    b.Property<int>("CompanyID")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegionLatitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RegionLongitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RegionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RegionID");

                    b.HasIndex("CompanyID");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            RegionID = 1,
                            CompanyID = 1,
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2024, 6, 6, 3, 15, 53, 763, DateTimeKind.Utc).AddTicks(7196),
                            ModifiedBy = 1,
                            ModifiedDate = new DateTime(2024, 6, 6, 3, 15, 53, 763, DateTimeKind.Utc).AddTicks(7197),
                            RegionLatitude = "40.7128",
                            RegionLongitude = "-74.0060",
                            RegionName = "Jakarta Pusat"
                        });
                });

            modelBuilder.Entity("SMJP.MasterDataServices.API.Models.Schedules", b =>
                {
                    b.Property<int>("ScheduleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScheduleID"));

                    b.Property<int>("CompanyID")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RegionID")
                        .HasColumnType("int");

                    b.Property<int>("ShiftID")
                        .HasColumnType("int");

                    b.Property<int>("SiteID")
                        .HasColumnType("int");

                    b.HasKey("ScheduleID");

                    b.HasIndex("CompanyID");

                    b.HasIndex("RegionID");

                    b.HasIndex("ShiftID");

                    b.HasIndex("SiteID");

                    b.ToTable("Schedules");

                    b.HasData(
                        new
                        {
                            ScheduleID = 1,
                            CompanyID = 1,
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2024, 6, 6, 10, 15, 53, 763, DateTimeKind.Local).AddTicks(7402),
                            Date = new DateTime(2024, 6, 6, 10, 15, 53, 763, DateTimeKind.Local).AddTicks(7379),
                            ModifiedBy = 1,
                            ModifiedDate = new DateTime(2024, 6, 6, 10, 15, 53, 763, DateTimeKind.Local).AddTicks(7405),
                            RegionID = 1,
                            ShiftID = 1,
                            SiteID = 1
                        });
                });

            modelBuilder.Entity("SMJP.MasterDataServices.API.Models.Shifts", b =>
                {
                    b.Property<int>("ShiftID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShiftID"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ShiftID");

                    b.ToTable("Shifts");

                    b.HasData(
                        new
                        {
                            ShiftID = 1,
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2024, 6, 6, 3, 15, 53, 763, DateTimeKind.Utc).AddTicks(7650),
                            EndAt = new DateTime(2024, 6, 6, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedBy = 1,
                            ModifiedDate = new DateTime(2024, 6, 6, 3, 15, 53, 763, DateTimeKind.Utc).AddTicks(7652),
                            StartAt = new DateTime(2024, 6, 6, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Morning"
                        });
                });

            modelBuilder.Entity("SMJP.MasterDataServices.API.Models.Sites", b =>
                {
                    b.Property<int>("SiteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SiteID"));

                    b.Property<int>("CompanyID")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RegionID")
                        .HasColumnType("int");

                    b.Property<string>("SiteDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteLatitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteLongitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SiteID");

                    b.HasIndex("CompanyID");

                    b.HasIndex("RegionID");

                    b.ToTable("Sites");

                    b.HasData(
                        new
                        {
                            SiteID = 1,
                            CompanyID = 1,
                            CreatedBy = 1,
                            CreatedDate = new DateTime(2024, 6, 6, 3, 15, 53, 763, DateTimeKind.Utc).AddTicks(7293),
                            ModifiedBy = 1,
                            ModifiedDate = new DateTime(2024, 6, 6, 3, 15, 53, 763, DateTimeKind.Utc).AddTicks(7295),
                            RegionID = 1,
                            SiteDesc = "Description of Pertamina Site",
                            SiteLatitude = "48.8584",
                            SiteLongitude = "2.2945",
                            SiteName = "Pertamina Training & Consulting"
                        });
                });

            modelBuilder.Entity("SMJP.MasterDataServices.API.Models.Dto.Users", b =>
                {
                    b.HasOne("SMJP.MasterDataServices.API.Models.Companies", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMJP.MasterDataServices.API.Models.Regions", "Region")
                        .WithMany()
                        .HasForeignKey("RegionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMJP.MasterDataServices.API.Models.Sites", "Site")
                        .WithMany()
                        .HasForeignKey("SiteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Region");

                    b.Navigation("Site");
                });

            modelBuilder.Entity("SMJP.MasterDataServices.API.Models.Regions", b =>
                {
                    b.HasOne("SMJP.MasterDataServices.API.Models.Companies", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("SMJP.MasterDataServices.API.Models.Schedules", b =>
                {
                    b.HasOne("SMJP.MasterDataServices.API.Models.Companies", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMJP.MasterDataServices.API.Models.Regions", "Region")
                        .WithMany()
                        .HasForeignKey("RegionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMJP.MasterDataServices.API.Models.Shifts", "Shift")
                        .WithMany()
                        .HasForeignKey("ShiftID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMJP.MasterDataServices.API.Models.Sites", "Site")
                        .WithMany()
                        .HasForeignKey("SiteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Region");

                    b.Navigation("Shift");

                    b.Navigation("Site");
                });

            modelBuilder.Entity("SMJP.MasterDataServices.API.Models.Sites", b =>
                {
                    b.HasOne("SMJP.MasterDataServices.API.Models.Companies", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMJP.MasterDataServices.API.Models.Regions", "Region")
                        .WithMany()
                        .HasForeignKey("RegionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Region");
                });
#pragma warning restore 612, 618
        }
    }
}