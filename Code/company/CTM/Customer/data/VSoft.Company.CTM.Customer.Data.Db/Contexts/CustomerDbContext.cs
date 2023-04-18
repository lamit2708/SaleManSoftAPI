using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.CTM.Customer.Data.Entity.Models;

namespace VSoft.Company.CTM.Customer.Data.Db.Contexts;

public class CustomerDbContext : EfcDbContext<CustomerDbContext, MCustomerEntity>
{
    public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MCustomerEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MCustomerEntity> entity)
    {
        entity.ToTable("Customer");
    }

    protected void ConfigIndex(EntityTypeBuilder<MCustomerEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");

        //entity.HasIndex(e => e.CustomerInfoId, "FK_CustomerInfo_TO_Customer");

        entity.HasIndex(e => e.PriorityId, "FK_Priority_TO_Customer");

        entity.HasIndex(e => e.Phone, "UQ_Phone").IsUnique();
		//entity.HasIndex(e => e.CustomerSourceId, "FK_CustomerSource_TO_CustomerInfo");
	}

  
    protected void ConfigBasicFields(EntityTypeBuilder<MCustomerEntity> entity)
    {

        entity.Property(e => e.Id).HasColumnType("bigint(20)");
        entity.Property(e => e.Keyword).HasColumnType("varchar(512)").HasColumnName("Keyword");
        entity.Property(e => e.Address)
            .HasMaxLength(100)
            .HasDefaultValueSql("NULL");
        //entity.Property(e => e.CustomerInfoId)
        //    .HasDefaultValueSql("NULL")
        //    .HasColumnType("bigint(20)");
        entity.Property(e => e.Email).HasMaxLength(100);
        entity.Property(e => e.Gender)
            .HasDefaultValueSql("NULL")
            .HasComment("True: Male, False: Female");
        entity.Property(e => e.Name).HasMaxLength(100);
        entity.Property(e => e.Phone).HasMaxLength(100);
        entity.Property(e => e.PriorityId)
            .HasDefaultValueSql("NULL")
            .HasColumnType("int(11)");
        entity.Property(e => e.BirthDate).HasDefaultValueSql("NULL").HasColumnType("datetime");
        entity.Property(e => e.CustomerSourceId).HasDefaultValueSql("NULL").HasColumnType("int(11)");
        entity.Property(e => e.Hobby).HasMaxLength(512).HasDefaultValueSql("NULL");
        entity.Property(e => e.IsMarrage).HasDefaultValueSql("NULL");
        entity.Property(e => e.Job).HasMaxLength(100).HasDefaultValueSql("NULL");
    }

 

}
