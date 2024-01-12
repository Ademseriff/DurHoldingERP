﻿// <auto-generated />
using System;
using DurHoldingErp.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DurHoldingErp.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240112114721_mg13")]
    partial class mg13
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DurHoldingErp.Entity.Entities.BathCeramic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BarcodeId")
                        .HasColumnType("int");

                    b.Property<string>("CeramicAmount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CeramicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CeramicPrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("bathCeramics");
                });

            modelBuilder.Entity("DurHoldingErp.Entity.Entities.Closet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BarcodeId")
                        .HasColumnType("int");

                    b.Property<string>("ClosetAmount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClosetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClosetPrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("closets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4e88b523-0ac5-49e8-b75e-a45ea88b5331"),
                            BarcodeId = 8686,
                            ClosetAmount = "2000",
                            ClosetName = "Babel Rezervuarsız",
                            ClosetPrice = "6120",
                            CreateTime = new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(5595),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("61a18e57-523a-4256-9bf1-33ee982469cd"),
                            BarcodeId = 9288,
                            ClosetAmount = "1500",
                            ClosetName = "Babel Rezervuar",
                            ClosetPrice = "6400",
                            CreateTime = new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(5812),
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("DurHoldingErp.Entity.Entities.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("departments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"),
                            CreateTime = new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(6367),
                            DepartmentName = "yönetici",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("1c30332a-d7cc-4c29-abf9-b02bc87536eb"),
                            CreateTime = new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(6406),
                            DepartmentName = "It",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("14b482fc-8374-40ef-9bad-53f369b30771"),
                            CreateTime = new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(6413),
                            DepartmentName = "Ik",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("9b930dcd-fd15-43ce-be93-91c2b314a97f"),
                            CreateTime = new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(6418),
                            DepartmentName = "Security",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("b2ecb1dd-6c51-4bd6-862d-61df780de333"),
                            CreateTime = new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(6425),
                            DepartmentName = "Driver",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("173bf7c5-9f43-4f2a-afbd-f2a6e15b4d41"),
                            CreateTime = new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(6433),
                            DepartmentName = "Worker",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("65dcc325-b971-4979-ad4c-52fe91509d5a"),
                            CreateTime = new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(6438),
                            DepartmentName = "CEO or Deputy ceo",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("DurHoldingErp.Entity.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasDefaultValue("NULL");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sallary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed8"),
                            Age = 24,
                            CreateTime = new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(8480),
                            DepartmentId = new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"),
                            IsDeleted = false,
                            Name = "Adem Şerif",
                            Surname = "Dur"
                        });
                });

            modelBuilder.Entity("DurHoldingErp.Entity.Entities.KitchenCeramic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BarcodeId")
                        .HasColumnType("int");

                    b.Property<string>("CeramicAmount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CeramicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CeramicPrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("kitchenCeramics");

                    b.HasData(
                        new
                        {
                            Id = new Guid("979fc79e-f6ec-465d-968f-dda94a0b58c0"),
                            BarcodeId = 5429,
                            CeramicAmount = "400",
                            CeramicName = "xx02",
                            CeramicPrice = "3200",
                            CreateTime = new DateTime(2024, 1, 12, 14, 47, 20, 838, DateTimeKind.Local).AddTicks(9158),
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("DurHoldingErp.Entity.Entities.Users", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26331b"),
                            CreateTime = new DateTime(2024, 1, 12, 14, 47, 20, 839, DateTimeKind.Local).AddTicks(387),
                            Email = "ademserifd@gmail.com",
                            IsDeleted = false,
                            Name = "Adem",
                            Password = "123456",
                            Role = "Admin"
                        },
                        new
                        {
                            Id = new Guid("242dd5ef-f646-4bbe-9274-6fbb6a26981b"),
                            CreateTime = new DateTime(2024, 1, 12, 14, 47, 20, 839, DateTimeKind.Local).AddTicks(417),
                            Email = "ademserifd@gmail.com",
                            IsDeleted = false,
                            Name = "Kerem",
                            Password = "123456",
                            Role = "Admin"
                        });
                });

            modelBuilder.Entity("DurHoldingErp.Entity.Entities.Employee", b =>
                {
                    b.HasOne("DurHoldingErp.Entity.Entities.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("DurHoldingErp.Entity.Entities.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
