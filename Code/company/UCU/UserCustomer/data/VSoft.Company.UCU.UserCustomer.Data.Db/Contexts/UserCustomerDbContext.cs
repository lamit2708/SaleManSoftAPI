using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.UCU.UserCustomer.Data.Entity.Models;

namespace VSoft.Company.UCU.UserCustomer.Data.Db.Contexts;

public class UserCustomerDbContext : EfcDbContext<UserCustomerDbContext, MUserCustomerEntity>
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

  
    protected void ConfigBasicFields(EntityTypeBuilder<MUserCustomerEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("int(11)");
        entity.Property(e => e.CreatedDateTeam).HasColumnType("datetime");
        entity.Property(e => e.CreatedDateUser).HasColumnType("datetime");
        entity.Property(e => e.CustomerId).HasColumnType("bigint(20)");
        entity.Property(e => e.TeamId).HasColumnType("int(11)");
        entity.Property(e => e.UserId).HasDefaultValueSql("'NULL'").HasColumnType("int(11)");
    }

 

}
