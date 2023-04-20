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
        entity.HasNoKey().ToTable("VDealTag");
    }

    protected void ConfigIndex(EntityTypeBuilder<MVDealTagEntity> entity)
    {

	}

  
    protected void ConfigBasicFields(EntityTypeBuilder<MVDealTagEntity> entity)
    {

        entity.Property(e => e.CustomerId).HasColumnType("bigint(20)");
        entity.Property(e => e.CustomerName).HasMaxLength(100);
        entity.Property(e => e.CustomerPhone).HasMaxLength(100);
        entity.Property(e => e.DateFor).HasDefaultValueSql("'NULL'").HasColumnType("datetime");
        entity.Property(e => e.DealName).HasMaxLength(100).HasDefaultValueSql("'NULL'");
        entity.Property(e => e.DealStepId).HasColumnType("int(11)");
        entity.Property(e => e.Id).HasColumnType("bigint(20)");
        entity.Property(e => e.TeamId).HasDefaultValueSql("'NULL'").HasColumnType("int(11)");
        entity.Property(e => e.UserId).HasColumnType("int(11)");
        entity.Property(e => e.UserName).HasMaxLength(100);
    }

 

}
