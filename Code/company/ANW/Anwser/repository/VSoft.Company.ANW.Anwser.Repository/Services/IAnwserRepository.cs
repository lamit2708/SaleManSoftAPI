using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.ANW.Anwser.Data.Db.Contexts;
using VSoft.Company.ANW.Anwser.Data.Entity.Models;

namespace VSoft.Company.ANW.Anwser.Repository.Services;

public interface IAnwserRepository : IEfcRepositoryEntityMgmtId<AnwserDbContext, MAnwserEntity, long>
{

    string? GetFullName(long? id);

    Task<string?> GetFullNameAsync(long? id);
}
