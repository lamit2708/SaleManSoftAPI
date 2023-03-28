using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.PRC.ProductCategory.Data.Entity.Models;

namespace VSoft.Company.PRC.ProductCategory.Data.Db.Contexts;

public class ProductCategoryDbContext : EfcDbContext<ProductCategoryDbContext, MProductCategoryEntity>
{
    public ProductCategoryDbContext(DbContextOptions<ProductCategoryDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MProductCategoryEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);

        ConfigBasicFields(entity);

    }

    protected void ConfigTable(EntityTypeBuilder<MProductCategoryEntity> entity)
    {
        entity.ToTable("ProductCategory");
        //entity.ToTable("productcategory");
    }

    protected void ConfigIndex(EntityTypeBuilder<MProductCategoryEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
    }


    protected void ConfigBasicFields(EntityTypeBuilder<MProductCategoryEntity> entity)
    {

        entity.Property(e => e.Id).HasColumnType("int(11)");
        entity.Property(e => e.Name).HasMaxLength(50);
    }



}
