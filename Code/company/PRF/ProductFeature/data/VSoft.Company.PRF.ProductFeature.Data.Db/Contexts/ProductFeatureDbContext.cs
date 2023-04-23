using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.PRF.ProductFeature.Data.Entity.Models;

namespace VSoft.Company.PRF.ProductFeature.Data.Db.Contexts;

public class ProductFeatureDbContext : EfcDbContext<ProductFeatureDbContext, MProductFeatureEntity>
{
    public ProductFeatureDbContext(DbContextOptions<ProductFeatureDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MProductFeatureEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);

        ConfigBasicFields(entity);

    }

    protected void ConfigTable(EntityTypeBuilder<MProductFeatureEntity> entity)
    {
        entity.ToTable("ProductFeature");
    }

    protected void ConfigIndex(EntityTypeBuilder<MProductFeatureEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
    }


    protected void ConfigBasicFields(EntityTypeBuilder<MProductFeatureEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("int(11)");
        entity.Property(e => e.Description).HasMaxLength(512);
        entity.Property(e => e.Name).HasMaxLength(100);
        entity.Property(e => e.ProductId).HasColumnType("int(11)");

    }



}
