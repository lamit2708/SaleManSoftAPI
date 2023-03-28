using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.POR.ProductOrder.Data.Entity.Models;

namespace VSoft.Company.POR.ProductOrder.Data.Db.Contexts;

public class ProductOrderDbContext : EfcDbContext<ProductOrderDbContext, MProductOrderEntity>
{
    public ProductOrderDbContext(DbContextOptions<ProductOrderDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MProductOrderEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MProductOrderEntity> entity)
    {
        entity.ToTable("ProductOrder");
    }

    protected void ConfigIndex(EntityTypeBuilder<MProductOrderEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.HasIndex(e => e.OrderId, "FK_Order_TO_ProductOrder");
        entity.HasIndex(e => e.ProductId, "FK_Product_TO_ProductOrder");
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MProductOrderEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("int(11)");
        entity.Property(e => e.OrderId).HasColumnType("int(11)");
        entity.Property(e => e.ProductId).HasColumnType("int(11)");
        entity.Property(e => e.Quatity).HasColumnType("int(11)");
    }

 

}
