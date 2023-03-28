using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.ANW.Anwser.Data.Entity.Models;

namespace VSoft.Company.ANW.Anwser.Data.Db.Contexts;

public class AnwserDbContext : EfcDbContext<AnwserDbContext, MAnwserEntity>
{
    public AnwserDbContext(DbContextOptions<AnwserDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MAnwserEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MAnwserEntity> entity)
    {
        entity.ToTable("Anwser");
    }

    protected void ConfigIndex(EntityTypeBuilder<MAnwserEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.HasIndex(e => e.QuestionId, "FK_Question_TO_Anwser");
        entity.HasIndex(e => e.UserId, "FK_User_TO_Anwser");
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MAnwserEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("bigint(20)");
        entity.Property(e => e.Content).HasMaxLength(512);
        entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        entity.Property(e => e.QuestionId).HasColumnType("bigint(20)");
        entity.Property(e => e.UserId).HasColumnType("int(11)");
    }

 

}
