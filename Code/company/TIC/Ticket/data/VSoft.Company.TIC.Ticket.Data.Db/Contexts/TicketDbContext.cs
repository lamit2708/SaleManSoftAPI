using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.TIC.Ticket.Data.Entity.Models;

namespace VSoft.Company.TIC.Ticket.Data.Db.Contexts;

public class TicketDbContext : EfcDbContext<TicketDbContext, MTicketEntity>
{
    public TicketDbContext(DbContextOptions<TicketDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MTicketEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MTicketEntity> entity)
    {
        entity.ToTable("Ticket");
    }

    protected void ConfigIndex(EntityTypeBuilder<MTicketEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.HasIndex(e => e.CustomerId, "FK_Customer_TO_Ticket");
        entity.HasIndex(e => e.Name, "UQ_Name").IsUnique();
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MTicketEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("int(11)");
        entity.Property(e => e.CustomerId).HasColumnType("bigint(20)");
        entity.Property(e => e.Name).HasMaxLength(100).HasDefaultValueSql("'NULL'");
    }

 

}
