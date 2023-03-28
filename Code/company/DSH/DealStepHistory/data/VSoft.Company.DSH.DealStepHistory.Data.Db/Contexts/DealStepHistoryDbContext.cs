using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.DSH.DealStepHistory.Data.Entity.Models;

namespace VSoft.Company.DSH.DealStepHistory.Data.Db.Contexts;

public class DealStepHistoryDbContext : EfcDbContext<DealStepHistoryDbContext, MDealStepHistoryEntity>
{
    public DealStepHistoryDbContext(DbContextOptions<DealStepHistoryDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MDealStepHistoryEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MDealStepHistoryEntity> entity)
    {
        entity.ToTable("DealStepHistory");
    }

    protected void ConfigIndex(EntityTypeBuilder<MDealStepHistoryEntity> entity)
    {
        entity.HasKey(e => e.Id);
        entity.HasIndex(e => e.DealStepId, "FK_DealStep_TO_DealStepHistory");
        entity.HasIndex(e => e.Id, "FK_Deal_TO_DealStepHistory");
        entity.HasIndex(e => e.UserId, "FK_User_TO_DealStepHistory");
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MDealStepHistoryEntity> entity)
    {
        entity.Property(e => e.DateTime).HasColumnType("datetime");
        entity.Property(e => e.DealStepId).HasColumnType("int(11)");
        entity.Property(e => e.Id).HasColumnType("bigint(20)");
        entity.Property(e => e.UserId).HasColumnType("int(11)");
    }

 

}
