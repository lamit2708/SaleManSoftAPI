using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.CTM.Main.Data.Entity.Models;

namespace VSoft.Company.CTM.Main.Data.Db.Contexts;

public class MainDbContext : EfcDbContext<MainDbContext, MMainEntity>
{
    public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MMainEntity> builder)
    {
        ConfigTable(builder);

        ConfigIndex(builder);
    
        ConfigBasicFields(builder);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MMainEntity> builder)
    {
        builder.ToTable("Main");
    }

    protected void ConfigIndex(EntityTypeBuilder<MMainEntity> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");
        builder.HasIndex(e => e.MainInfoId, "FK_MainInfo_TO_Main");

        builder.HasIndex(e => e.PriorityId, "FK_Priority_TO_Main");

        builder.HasIndex(e => e.Phone, "UQ_Phone").IsUnique();
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MMainEntity> builder)
    {
        builder.Property(e => e.Id).HasColumnType("bigint(20)");
        builder.Property(e => e.Address).HasMaxLength(100).HasDefaultValueSql("'NULL'");
        builder.Property(e => e.MainInfoId).HasDefaultValueSql("'NULL'").HasColumnType("bigint(20)");
        builder.Property(e => e.Email).HasMaxLength(100);
        builder.Property(e => e.Gender).HasDefaultValueSql("'NULL'").HasComment("True: Male, False: Female");
        builder.Property(e => e.Name).HasMaxLength(100);
        builder.Property(e => e.Phone).HasMaxLength(100);
        builder.Property(e => e.PriorityId).HasDefaultValueSql("'NULL'").HasColumnType("int(11)");
    }

 

}
