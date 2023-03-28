using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.TEA.Team.Data.Entity.Models;

namespace VSoft.Company.TEA.Team.Data.Db.Contexts;

public class TeamDbContext : EfcDbContext<TeamDbContext, MTeamEntity>
{
    public TeamDbContext(DbContextOptions<TeamDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MTeamEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MTeamEntity> entity)
    {
        entity.ToTable("Team");
    }

    protected void ConfigIndex(EntityTypeBuilder<MTeamEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
    }


    protected void ConfigBasicFields(EntityTypeBuilder<MTeamEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("int(11)");
        entity.Property(e => e.Description).HasMaxLength(512);
        entity.Property(e => e.Name).HasMaxLength(100);
    }

 

}
