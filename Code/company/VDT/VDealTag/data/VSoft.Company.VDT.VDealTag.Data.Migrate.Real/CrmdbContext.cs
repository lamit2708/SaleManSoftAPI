using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VSoft.Company.VDT.VDealTag.Data.Migrate.Real;

public partial class CrmdbContext : DbContext
{
    public CrmdbContext()
    {
    }

    public CrmdbContext(DbContextOptions<CrmdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Vdealtag> Vdealtags { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Data Source=103.15.50.87; Initial Catalog=crmdb;USER ID=root;Password=PtKHDjkgJDRn8BAb;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Vdealtag>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vdealtag");

            entity.Property(e => e.CustomerId).HasColumnType("bigint(20)");
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.CustomerPhone).HasMaxLength(100);
            entity.Property(e => e.DateFor)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime");
            entity.Property(e => e.DealName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.DealStepId).HasColumnType("int(11)");
            entity.Property(e => e.Id).HasColumnType("bigint(20)");
            entity.Property(e => e.TeamId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)");
            entity.Property(e => e.UserId).HasColumnType("int(11)");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
