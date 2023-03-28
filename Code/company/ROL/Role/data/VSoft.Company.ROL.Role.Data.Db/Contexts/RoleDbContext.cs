using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.ROL.Role.Data.Entity.Models;

namespace VSoft.Company.ROL.Role.Data.Db.Contexts;

public class RoleDbContext : EfcDbContext<RoleDbContext, MRoleEntity>
{
    public RoleDbContext(DbContextOptions<RoleDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MRoleEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MRoleEntity> entity)
    {
        entity.ToTable("Role");
    }

    protected void ConfigIndex(EntityTypeBuilder<MRoleEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MRoleEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("int(11)");
        entity.Property(e => e.Description).HasMaxLength(512);
        entity.Property(e => e.Name).HasMaxLength(100);
    }

 

}
