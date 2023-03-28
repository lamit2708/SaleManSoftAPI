using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.DAC.DealActivity.Data.Entity.Models;

namespace VSoft.Company.DAC.DealActivity.Data.Db.Contexts;

public class DealActivityDbContext : EfcDbContext<DealActivityDbContext, MDealActivityEntity>
{
    public DealActivityDbContext(DbContextOptions<DealActivityDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MDealActivityEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MDealActivityEntity> entity)
    {
        entity.ToTable("DealActivity");
    }

    protected void ConfigIndex(EntityTypeBuilder<MDealActivityEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.HasIndex(e => e.ActivityId, "FK_Activity_TO_DealActivity");
        entity.HasIndex(e => e.DealId, "FK_Deal_TO_DealActivity");
        entity.HasIndex(e => e.UserId, "FK_User_TO_DealActivity");
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MDealActivityEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("int(11)");
        entity.Property(e => e.ActivityId).HasColumnType("int(11)");
        entity.Property(e => e.Content).HasMaxLength(512);
        entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        entity.Property(e => e.DealId).HasColumnType("bigint(20)");
        entity.Property(e => e.Subject).HasMaxLength(100);
        entity.Property(e => e.UserId).HasColumnType("int(11)");
    }

 

}
