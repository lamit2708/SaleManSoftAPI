﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VSoft.Company.CTM.Customer.Data.Db.Contexts;

#nullable disable

namespace VSoft.Company.CTM.Customer.Data.Migrate.Real.Migrations
{
    [DbContext(typeof(CustomerDbContext))]
    [Migration("20230418094734_JoinCustomerInfo")]
    partial class JoinCustomerInfo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("VSoft.Company.CTM.Customer.Data.Entity.Models.MCustomerEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint(20)");

                    b.Property<string>("Address")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasDefaultValueSql("NULL");

                    b.Property<DateTime?>("BirthDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("NULL");

                    b.Property<int?>("CustomerSourceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasDefaultValueSql("NULL");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool?>("Gender")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValueSql("NULL")
                        .HasComment("True: Male, False: Female");

                    b.Property<string>("Hobby")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)")
                        .HasDefaultValueSql("NULL");

                    b.Property<bool>("IsBought")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("IsMarrage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValueSql("NULL");

                    b.Property<string>("Job")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasDefaultValueSql("NULL");

                    b.Property<string>("Keyword")
                        .HasColumnType("varchar(512)")
                        .HasColumnName("Keyword");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("PriorityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasDefaultValueSql("NULL");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "PriorityId" }, "FK_Priority_TO_Customer");

                    b.HasIndex(new[] { "Phone" }, "UQ_Phone")
                        .IsUnique();

                    b.ToTable("Customer", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}