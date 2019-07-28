﻿// <auto-generated />
using System;
using Back.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Back.DAL.Migrations
{
    [DbContext(typeof(UAppContext))]
    [Migration("20190725064955_addSession")]
    partial class addSession
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Back.DAL.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("__Item__");
                });

            modelBuilder.Entity("Back.DAL.Models.ParamValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemId")
                        .HasColumnName("ItemId");

                    b.Property<int>("SymbolId")
                        .HasColumnName("SymbolId");

                    b.Property<DateTime>("TradingDate")
                        .HasColumnType("DateTime");

                    b.Property<decimal>("Value")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 38, scale: 17)))
                        .HasColumnType("DECIMAL(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("SymbolId");

                    b.ToTable("__ParamValue__");
                });

            modelBuilder.Entity("Back.DAL.Models.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId");

                    b.Property<byte[]>("UserSession");

                    b.HasKey("Id");

                    b.ToTable("__Session__");
                });

            modelBuilder.Entity("Back.DAL.Models.Symbol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("__Symbol__");
                });

            modelBuilder.Entity("Back.DAL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("CheckSum")
                        .HasColumnType("VARCHAR(64)")
                        .HasMaxLength(64);

                    b.Property<string>("Email")
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(255);

                    b.Property<string>("FamilyName")
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(255);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(12);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("__User__");
                });

            modelBuilder.Entity("Back.DAL.Models.ParamValue", b =>
                {
                    b.HasOne("Back.DAL.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Back.DAL.Models.Symbol", "Symbol")
                        .WithMany()
                        .HasForeignKey("SymbolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
