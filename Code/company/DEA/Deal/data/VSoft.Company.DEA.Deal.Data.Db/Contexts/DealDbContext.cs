using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.DEA.Deal.Data.Entity.Models;

namespace VSoft.Company.DEA.Deal.Data.Db.Contexts;

public class DealDbContext : EfcDbContext<DealDbContext, MDealEntity>
{
    public virtual DbSet<MDealViewEntity>? ViewItems { get; set; }
    public DealDbContext(DbContextOptions<DealDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity(new Action<EntityTypeBuilder<MDealViewEntity>>(ConfigureViewEntity));
    }

    private void ConfigureViewEntity(EntityTypeBuilder<MDealViewEntity> entity)
    {
        entity.ToTable("DealView");
        entity.Property(e => e.Id).HasColumnType("bigint(20)");
        entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        entity.Property(e => e.DateFor).HasColumnType("datetime");
        entity.Property(e => e.CustomerId).HasColumnType("bigint(20)");
        entity.Property(e => e.DealStepId).HasColumnType("int(11)");
        entity.Property(e => e.UserId).HasColumnType("int(11)");
        entity.Property(e => e.Description).HasMaxLength(512).HasDefaultValueSql("'NULL'");
        entity.Property(e => e.Name).HasMaxLength(100).HasDefaultValueSql("'NULL'");
        entity.Property(e => e.PridictPrice).HasColumnType("bigint(20)");
        entity.Property(e => e.PricePossible).HasColumnType("bigint(20)");
        entity.Property(e => e.OrderId).HasDefaultValueSql("'NULL'").HasColumnType("int(11)");
        entity.Property(e => e.UserId).HasColumnType("int(11)");
        entity.Property(e => e.CustomerFullName).HasMaxLength(100).HasDefaultValueSql("'NULL'");
        entity.Property(e => e.UserFullName).HasMaxLength(100).HasDefaultValueSql("'NULL'");
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MDealEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MDealEntity> entity)
    {
        entity.ToTable("Deal");
    }

    protected void ConfigIndex(EntityTypeBuilder<MDealEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.HasIndex(e => e.CustomerId, "FK_Customer_TO_Deal");
        //entity.HasIndex(e => e.DealStepId, "FK_DealStep_TO_Deal");
        entity.HasIndex(e => e.OrderId, "FK_Order_TO_Deal");
        entity.HasIndex(e => e.UserId, "FK_User_TO_Deal");
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MDealEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("bigint(20)");
        entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        entity.Property(e => e.DateFor).HasColumnType("datetime");
        entity.Property(e => e.CustomerId).HasColumnType("bigint(20)");
        entity.Property(e => e.DealStepId).HasColumnType("int(11)");
        entity.Property(e => e.UserId).HasColumnType("int(11)");
        entity.Property(e => e.Description).HasMaxLength(512).HasDefaultValueSql("'NULL'");
        entity.Property(e => e.Name).HasMaxLength(100).HasDefaultValueSql("'NULL'");
        entity.Property(e => e.PridictPrice).HasColumnType("bigint(20)");
        entity.Property(e => e.PricePossible).HasColumnType("bigint(20)");
        entity.Property(e => e.OrderId).HasDefaultValueSql("'NULL'").HasColumnType("int(11)");
        entity.Property(e => e.UserId).HasColumnType("int(11)");
    }

 

}
