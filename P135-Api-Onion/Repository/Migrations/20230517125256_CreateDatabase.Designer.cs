﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Data;

#nullable disable

namespace Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230517125256_CreateDatabase")]
    partial class CreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 5, 17, 16, 52, 56, 91, DateTimeKind.Local).AddTicks(1727),
                            Name = "Azerbaycan",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 5, 17, 16, 52, 56, 91, DateTimeKind.Local).AddTicks(1728),
                            Name = "Turkiye",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 5, 17, 16, 52, 56, 91, DateTimeKind.Local).AddTicks(1729),
                            Name = "Ingiltere",
                            SoftDelete = false
                        });
                });

            modelBuilder.Entity("Domain.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Sumqayit",
                            Age = 27,
                            CreatedAt = new DateTime(2023, 5, 17, 16, 52, 56, 91, DateTimeKind.Local).AddTicks(1606),
                            FullName = "Roya Meherremova",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 2,
                            Address = "Xetai",
                            Age = 28,
                            CreatedAt = new DateTime(2023, 5, 17, 16, 52, 56, 91, DateTimeKind.Local).AddTicks(1619),
                            FullName = "Anar Aliyev",
                            SoftDelete = false
                        },
                        new
                        {
                            Id = 3,
                            Address = "Nesimi",
                            Age = 18,
                            CreatedAt = new DateTime(2023, 5, 17, 16, 52, 56, 91, DateTimeKind.Local).AddTicks(1620),
                            FullName = "Mubariz Agayev",
                            SoftDelete = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
