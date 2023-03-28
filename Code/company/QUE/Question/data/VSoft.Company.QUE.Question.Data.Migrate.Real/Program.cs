using VegunSoft.Framework.Efc.Migrate.Provider.MySQL.Services;
using VSoft.Company.QUE.Question.Data.Db.Contexts;
using VSoft.Company.QUE.Question.Data.Entity.Models;
await new EfcSingleMigrateServiceMySQL<QuestionDbContext, MQuestionEntity>().LogCount();