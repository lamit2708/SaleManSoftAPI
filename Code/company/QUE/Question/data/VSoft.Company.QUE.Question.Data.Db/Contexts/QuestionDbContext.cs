using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VegunSoft.Framework.Efc.Contexts;
using VSoft.Company.QUE.Question.Data.Entity.Models;

namespace VSoft.Company.QUE.Question.Data.Db.Contexts;

public class QuestionDbContext : EfcDbContext<QuestionDbContext, MQuestionEntity>
{
    public QuestionDbContext(DbContextOptions<QuestionDbContext> options) : base(options)
    {
    }

    protected override void ConfigureEntity(EntityTypeBuilder<MQuestionEntity> entity)
    {
        ConfigTable(entity);

        ConfigIndex(entity);
    
        ConfigBasicFields(entity);
       
    }

    protected void ConfigTable(EntityTypeBuilder<MQuestionEntity> entity)
    {
        entity.ToTable("Question");
    }

    protected void ConfigIndex(EntityTypeBuilder<MQuestionEntity> entity)
    {
        entity.HasKey(e => e.Id).HasName("PRIMARY");
        entity.HasIndex(e => e.TicketId, "FK_Ticket_TO_Question");
    }

  
    protected void ConfigBasicFields(EntityTypeBuilder<MQuestionEntity> entity)
    {
        entity.Property(e => e.Id).HasColumnType("bigint(20)");
        entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        entity.Property(e => e.Description).HasMaxLength(512);
        entity.Property(e => e.TicketId).HasColumnType("int(11)");
    }

 

}
