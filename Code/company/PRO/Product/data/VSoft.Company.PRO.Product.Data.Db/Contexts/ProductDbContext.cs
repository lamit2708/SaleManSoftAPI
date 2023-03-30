using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.PRO.Product.Data.Entity.Models;

namespace VSoft.Company.PRO.Product.Data.Db.Contexts;

public class ProductDbContext : EfcDbContext<ProductDbContext, MProductEntity>
{
    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MProductEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MProductEntity> entity)
    {
        entity.ToTable("Product");
    }

    protected void ConfigIndex(EntityTypeBuilder<MProductEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");

    }


    protected void ConfigBasicFields(EntityTypeBuilder<MProductEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("int(11)");
        entity.Property(e => e.Category).HasMaxLength(100).HasDefaultValueSql("'NULL'");
        entity.Property(e => e.Description).HasMaxLength(512).HasDefaultValueSql("'NULL'");
        entity.Property(e => e.Name).HasMaxLength(100);
        entity.Property(e => e.Quantity).HasColumnType("int(11)");
        entity.Property(e => e.Keyword).HasColumnType("varchar(512)").HasColumnName("Keyword");
    }

 

}
