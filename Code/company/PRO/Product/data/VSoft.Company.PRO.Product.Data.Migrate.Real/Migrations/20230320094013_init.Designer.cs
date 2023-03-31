﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VSoft.Company.PRO.Product.Data.Db.Contexts;

#nullable disable

namespace VSoft.Company.PRO.Product.Data.Migrate.Real.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20230320094013_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("VSoft.Company.PRO.Product.Data.Entity.Models.MProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<int>("CategoryId")
                       .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("Description")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("Quantity")
                        .HasColumnType("int(11)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("Product", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
