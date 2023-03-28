using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.USR.User.Data.Entity.Models;

namespace VSoft.Company.USR.User.Data.Db.Contexts;

public class UserDbContext : EfcDbContext<UserDbContext, MUserEntity>
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MUserEntity> builder)
    {
        ConfigTable(builder);

        ConfigIndex(builder);
    
        ConfigBasicFields(builder);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MUserEntity> builder)
    {
        builder.ToTable("user");
    }

    protected void ConfigIndex(EntityTypeBuilder<MUserEntity> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");
        builder.HasIndex(e => e.TeamId, "FK_Team_TO_User");
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MUserEntity> builder)
    {
        builder.Property(e => e.Id).HasColumnType("int(11)");
        builder.Property(e => e.Email)
            .HasMaxLength(100)
            .HasDefaultValueSql("'NULL'");
        builder.Property(e => e.Name).HasMaxLength(100);
        builder.Property(e => e.Password).HasMaxLength(100);
        builder.Property(e => e.Phone).HasMaxLength(100);
        builder.Property(e => e.TeamId)
            .HasDefaultValueSql("'NULL'")
            .HasColumnType("int(11)");
        builder.Property(e => e.Username).HasMaxLength(100);
    }

 

}
