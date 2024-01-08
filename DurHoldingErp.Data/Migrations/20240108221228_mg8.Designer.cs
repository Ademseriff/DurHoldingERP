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
    [Migration("20240108221228_mg8")]
    partial class mg8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
                            CreateTime = new DateTime(2024, 1, 9, 1, 12, 27, 659, DateTimeKind.Local).AddTicks(410),
                            DepartmentName = "yönetici",
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
                            CreateTime = new DateTime(2024, 1, 9, 1, 12, 27, 659, DateTimeKind.Local).AddTicks(1872),
                            DepartmentId = new Guid("6dce8fd3-ebce-4669-80af-b74b75911ed6"),
                            IsDeleted = false,
                            Name = "Adem Şerif",
                            Surname = "Dur"
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
