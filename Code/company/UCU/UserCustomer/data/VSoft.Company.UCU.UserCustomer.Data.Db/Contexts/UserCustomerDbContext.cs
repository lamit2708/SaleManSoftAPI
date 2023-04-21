using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.UCU.UserCustomer.Data.Entity.Models;

namespace VSoft.Company.UCU.UserCustomer.Data.Db.Contexts;

public class UserCustomerDbContext : EfcDbViewContext<UserCustomerDbContext, MUserCustomerEntity, MUserCustomerViewEntity>
{
    public UserCustomerDbContext(DbContextOptions<UserCustomerDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MUserCustomerEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MUserCustomerEntity> entity)
    {
        entity.ToTable("UserCustomer");
    }

    protected void ConfigIndex(EntityTypeBuilder<MUserCustomerEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.HasIndex(e => e.CustomerId, "FK_Customer_TO_UserCustomer");
        entity.HasIndex(e => e.TeamId, "FK_Team_TO_UserCustomer");
        entity.HasIndex(e => e.UserId, "FK_User_TO_UserCustomer");
    }

  
    protected void ConfigBasicFields<T>(EntityTypeBuilder<T> entity) where T : MUserCustomerEntityBasic
    {
        entity.Property(e => e.Id).HasColumnType("int(11)");
        entity.Property(e => e.CreatedDateTeam).HasColumnType("datetime");
        entity.Property(e => e.CreatedDateUser).HasColumnType("datetime");
        entity.Property(e => e.CustomerId).HasColumnType("bigint(20)");
        entity.Property(e => e.TeamId).HasColumnType("int(11)");
        entity.Property(e => e.UserId).HasDefaultValueSql("'NULL'").HasColumnType("int(11)");
    }

    protected override void ConfigureViewEntity(EntityTypeBuilder<MUserCustomerViewEntity> entity)
    {
        entity.ToTable("UserCustomerView");

        ConfigBasicFields(entity);

        entity.Property(e => e.CustomerFullName).HasMaxLength(100).HasDefaultValueSql("'NULL'");
        entity.Property(e => e.UserFullName).HasMaxLength(100).HasDefaultValueSql("'NULL'");
        entity.Property(e => e.TeamName).HasMaxLength(100).HasDefaultValueSql("'NULL'");
    }
}
