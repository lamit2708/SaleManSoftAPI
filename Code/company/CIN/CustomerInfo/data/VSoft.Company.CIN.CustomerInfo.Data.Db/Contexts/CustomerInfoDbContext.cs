using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.CIN.CustomerInfo.Data.Entity.Models;

namespace VSoft.Company.CIN.CustomerInfo.Data.Db.Contexts;

public class CustomerInfoDbContext : EfcDbContext<CustomerInfoDbContext, MCustomerInfoEntity>
{
    public CustomerInfoDbContext(DbContextOptions<CustomerInfoDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MCustomerInfoEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MCustomerInfoEntity> entity)
    {
        entity.ToTable("CustomerInfo");
    }

    protected void ConfigIndex(EntityTypeBuilder<MCustomerInfoEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.HasIndex(e => e.CustomerSourceId, "FK_CustomerSource_TO_CustomerInfo");
    }


    protected void ConfigBasicFields(EntityTypeBuilder<MCustomerInfoEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("bigint(20)");
        entity.Property(e => e.BirthDate).HasDefaultValueSql("'NULL'").HasColumnType("datetime");
        entity.Property(e => e.CustomerSourceId).HasDefaultValueSql("'NULL'").HasColumnType("int(11)");
        entity.Property(e => e.Hobby).HasMaxLength(512).HasDefaultValueSql("'NULL'");
        entity.Property(e => e.IsMarrage).HasDefaultValueSql("'NULL'");
        entity.Property(e => e.Job).HasMaxLength(100).HasDefaultValueSql("'NULL'");
    }

 

}
