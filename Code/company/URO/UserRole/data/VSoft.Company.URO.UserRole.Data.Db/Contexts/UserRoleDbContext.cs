using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.URO.UserRole.Data.Entity.Models;

namespace VSoft.Company.URO.UserRole.Data.Db.Contexts;

public class UserRoleDbContext : EfcDbContext<UserRoleDbContext, MUserRoleEntity>
{
    public UserRoleDbContext(DbContextOptions<UserRoleDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MUserRoleEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MUserRoleEntity> entity)
    {
        entity.ToTable("UserRole");
    }

    protected void ConfigIndex(EntityTypeBuilder<MUserRoleEntity> entity)
    {
        entity.HasKey(e => e.Id);
        entity.HasIndex(e => e.RoleId, "FK_Role_TO_UserRole");
        entity.HasIndex(e => e.UserId, "FK_User_TO_UserRole");
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MUserRoleEntity> entity)
    {
        entity.Property(e => e.RoleId).HasColumnType("int(11)");
        entity.Property(e => e.UserId).HasColumnType("int(11)");
    }

 

}
