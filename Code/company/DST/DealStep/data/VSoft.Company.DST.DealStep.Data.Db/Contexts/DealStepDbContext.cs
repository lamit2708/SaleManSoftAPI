using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.DST.DealStep.Data.Entity.Models;

namespace VSoft.Company.DST.DealStep.Data.Db.Contexts;

public class DealStepDbContext : EfcDbContext<DealStepDbContext, MDealStepEntity>
{
    public DealStepDbContext(DbContextOptions<DealStepDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MDealStepEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MDealStepEntity> entity)
    {
        entity.ToTable("DealStep");
    }

    protected void ConfigIndex(EntityTypeBuilder<MDealStepEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
    }


    protected void ConfigBasicFields(EntityTypeBuilder<MDealStepEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("int(11)");
        entity.Property(e => e.Description).HasMaxLength(512).HasDefaultValueSql("'NULL'");
        entity.Property(e => e.Name).HasMaxLength(100);
    }

 

}
