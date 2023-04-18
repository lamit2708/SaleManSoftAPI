using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.VDT.VDealTag.Data.Entity.Models;

namespace VSoft.Company.VDT.VDealTag.Data.Db.Contexts;

public class VDealTagDbContext : EfcDbContext<VDealTagDbContext, MVDealTagEntity>
{
    public VDealTagDbContext(DbContextOptions<VDealTagDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MVDealTagEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MVDealTagEntity> entity)
    {
        entity.ToTable("VDealTag");
    }

    protected void ConfigIndex(EntityTypeBuilder<MVDealTagEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.HasIndex(e => e.Id, "FK_Priority_TO_VDealTag");
        entity.HasIndex(e => e.CustomerId, "UQ_CustomerId").IsUnique();
	}

  
    protected void ConfigBasicFields(EntityTypeBuilder<MVDealTagEntity> entity)
    {

        entity.Property(e => e.Id).HasColumnType("bigint(20)");
        entity.Property(e => e.CustomerId).HasColumnType("bigint(20)");
        entity.Property(e => e.DealName).HasColumnType("varchar(100)");
        entity.Property(e => e.CustomerName).HasColumnType("varchar(100)");
        entity.Property(e => e.CustomerPhone).HasColumnType("varchar(100)");
        entity.Property(e => e.PridictPrice).HasColumnType("bigint(20)");
        entity.Property(e => e.DealStepId).HasColumnType("int(11)");
    }

 

}
