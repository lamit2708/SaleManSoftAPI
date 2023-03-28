﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VSoft.Company.ANW.Anwser.Data.Db.Contexts;

#nullable disable

namespace VSoft.Company.ANW.Anwser.Data.Migrate.Real.Migrations
{
    [DbContext(typeof(AnwserDbContext))]
    partial class AnwserDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("VSoft.Company.ANW.Anwser.Data.Entity.Models.MAnwserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(128)
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("CreatedDate");

                    b.Property<string>("FullName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("FullName");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("IsDeleted");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id")
                        .HasName("pk_Anwser");

                    b.HasIndex(new[] { "FullName" }, "IDX_Anwser_FullName");

                    b.ToTable("Anwser", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
