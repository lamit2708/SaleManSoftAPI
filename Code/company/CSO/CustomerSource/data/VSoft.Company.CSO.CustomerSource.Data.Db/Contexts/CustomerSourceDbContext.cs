using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.CSO.CustomerSource.Data.Entity.Models;

namespace VSoft.Company.CSO.CustomerSource.Data.Db.Contexts;

public class CustomerSourceDbContext : EfcDbContext<CustomerSourceDbContext, MCustomerSourceEntity>
{
    public CustomerSourceDbContext(DbContextOptions<CustomerSourceDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MCustomerSourceEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MCustomerSourceEntity> entity)
    {
        entity.ToTable("CustomerSource");
    }

    protected void ConfigIndex(EntityTypeBuilder<MCustomerSourceEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.HasIndex(e => e.Name, "UQ_Name").IsUnique();
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MCustomerSourceEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("int(11)");
        entity.Property(e => e.Description).HasMaxLength(512);
        entity.Property(e => e.Name).HasMaxLength(100);
    }

 

}
