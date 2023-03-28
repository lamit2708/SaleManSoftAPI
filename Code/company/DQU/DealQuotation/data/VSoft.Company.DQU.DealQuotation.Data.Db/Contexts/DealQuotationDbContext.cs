using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.DQU.DealQuotation.Data.Entity.Models;

namespace VSoft.Company.DQU.DealQuotation.Data.Db.Contexts;

public class DealQuotationDbContext : EfcDbContext<DealQuotationDbContext, MDealQuotationEntity>
{
    public DealQuotationDbContext(DbContextOptions<DealQuotationDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MDealQuotationEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MDealQuotationEntity> entity)
    {
        entity.ToTable("DealQuotation");
    }

    protected void ConfigIndex(EntityTypeBuilder<MDealQuotationEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.HasIndex(e => e.DealId, "FK_Deal_TO_DealQuotation");
        entity.HasIndex(e => e.ProductId, "FK_Product_TO_DealQuotation");
        entity.HasIndex(e => e.UserId, "FK_User_TO_DealQuotation");
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MDealQuotationEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("bigint(20)");
        entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        entity.Property(e => e.DealId).HasColumnType("bigint(20)");
        entity.Property(e => e.ProductId).HasColumnType("int(11)");
        entity.Property(e => e.Quatitty).HasColumnType("int(11)");
        entity.Property(e => e.UserId).HasColumnType("int(11)");
    }

 

}
