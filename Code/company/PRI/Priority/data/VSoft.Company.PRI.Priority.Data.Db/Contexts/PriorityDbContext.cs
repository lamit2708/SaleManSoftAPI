using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.PRI.Priority.Data.Entity.Models;

namespace VSoft.Company.PRI.Priority.Data.Db.Contexts;

public class PriorityDbContext : EfcDbContext<PriorityDbContext, MPriorityEntity>
{
    public PriorityDbContext(DbContextOptions<PriorityDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MPriorityEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MPriorityEntity> entity)
    {
        entity.ToTable("Priority");
    }

    protected void ConfigIndex(EntityTypeBuilder<MPriorityEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MPriorityEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("int(11)");
        entity.Property(e => e.Description).HasMaxLength(512);
        entity.Property(e => e.Name).HasMaxLength(100);
    }

 

}
