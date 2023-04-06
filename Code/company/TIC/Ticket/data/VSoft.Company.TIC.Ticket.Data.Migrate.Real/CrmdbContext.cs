using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VSoft.Company.TIC.Ticket.Data.Migrate.Real;

public partial class CrmdbContext : DbContext
{
    public CrmdbContext()
    {
    }

    public CrmdbContext(DbContextOptions<CrmdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ticket> Tickets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Data Source=103.15.50.87;Initial Catalog=crmdb;USER ID=root;Password=root");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ticket");

            entity.HasIndex(e => e.CustomerId, "FK_Customer_TO_Ticket");

            entity.HasIndex(e => e.Name, "UQ_Name").IsUnique();

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.CustomerId).HasColumnType("bigint(20)");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NULL'");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
