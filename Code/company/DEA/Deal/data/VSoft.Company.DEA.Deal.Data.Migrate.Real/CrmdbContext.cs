using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VSoft.Company.DEA.Deal.Data.Migrate.Real;

public partial class CrmdbContext : DbContext
{
    public CrmdbContext()
    {
    }

    public CrmdbContext(DbContextOptions<CrmdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Deal> Deals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Data Source=localhost;Initial Catalog=crmdb;User ID=root;Password=root");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Deal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("deal");

            entity.HasIndex(e => e.DealId, "FK_Deal_TO_Deal");

            entity.HasIndex(e => e.DealStepId, "FK_DealStep_TO_Deal");

            entity.HasIndex(e => e.OrderId, "FK_Order_TO_Deal");

            entity.HasIndex(e => e.UserId, "FK_User_TO_Deal");

            entity.Property(e => e.Id).HasColumnType("bigint(20)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DealId).HasColumnType("bigint(20)");
            entity.Property(e => e.DealStepId).HasColumnType("int(11)");
            entity.Property(e => e.Description)
                .HasMaxLength(512)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.OrderId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)");
            entity.Property(e => e.UserId).HasColumnType("int(11)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
