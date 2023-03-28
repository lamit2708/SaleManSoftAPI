using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.ANW.Anwser.Data.Db.Contexts;
using VSoft.Company.ANW.Anwser.Data.Entity.Models;
using VSoft.Company.ANW.Anwser.Repository.Services;

namespace VSoft.Company.ANW.Anwser.Repository.Efc.Services;

public interface IAnwserRepositoryEfc : IAnwserRepository, IEfcRepositoryEntityMgmtId<AnwserDbContext, MAnwserEntity, long>
{
   
}
