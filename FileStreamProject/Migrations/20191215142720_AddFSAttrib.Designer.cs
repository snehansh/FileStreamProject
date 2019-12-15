﻿// <auto-generated />
using System;
using FileStreamProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FileStreamProject.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20191215142720_AddFSAttrib")]
    partial class AddFSAttrib
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FileStreamProject.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Document")
                        .HasColumnType("VARBINARY(MAX) FILESTREAM");

                    b.Property<int>("DurationInYears")
                        .HasColumnType("int");

                    b.Property<Guid>("EmployeeGuid")
                        .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasAlternateKey("EmployeeGuid");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}