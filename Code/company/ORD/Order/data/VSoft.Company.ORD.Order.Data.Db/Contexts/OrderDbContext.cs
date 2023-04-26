using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.ORD.Order.Data.Entity.Models;

namespace VSoft.Company.ORD.Order.Data.Db.Contexts;

public class OrderDbContext : EfcDbContext<OrderDbContext, MOrderEntity>
{
    public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MOrderEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MOrderEntity> entity)
    {
        entity.ToTable("Order");
    }

    protected void ConfigIndex(EntityTypeBuilder<MOrderEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        //entity.HasKey(e => e.Id).HasName("PRIMARY");
        //entity.HasIndex(e => e.CustomerId, "FK_Customer_TO_Order");
        //entity.HasIndex(e => e.UserId, "FK_User_TO_Order");
        entity.HasIndex(e => e.CustomerId, "FK_Customer_TO_Order");

        entity.HasIndex(e => e.UserId, "FK_User_TO_Order");

        entity.HasIndex(e => e.EditedUserId, "FK_User_TO_Order1");
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MOrderEntity> entity)
    {
        //entity.Property(e => e.Id).HasColumnType("int(11)");
        //entity.Property(e => e.CreatedDate).HasDefaultValueSql("NULL").HasColumnType("datetime");
        //entity.Property(e => e.CustomerId).HasColumnType("bigint(20)");
        //entity.Property(e => e.UserId).HasColumnType("int(11)");

        entity.Property(e => e.Id).HasColumnType("int(11)");
        entity.Property(e => e.CreatedDate)
            .HasDefaultValueSql("NULL")
            .HasColumnType("datetime");
        entity.Property(e => e.CustomerId).HasColumnType("bigint(20)");
        entity.Property(e => e.DealId)
            .HasDefaultValueSql("NULL")
            .HasColumnType("bigint(20)");
        entity.Property(e => e.EditedDate)
            .HasDefaultValueSql("NULL")
            .HasColumnType("datetime");
        entity.Property(e => e.EditedUserId)
            .HasDefaultValueSql("NULL")
            .HasColumnType("int(11)");
        entity.Property(e => e.IsDraft)
            .IsRequired()
            .HasDefaultValueSql("1");
        entity.Property(e => e.UserId).HasColumnType("int(11)");
    }

 

}
