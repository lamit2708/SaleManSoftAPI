using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.DQU.DealQuotation.Data.Db.Contexts;
using VSoft.Company.DQU.DealQuotation.Data.Entity.Models;

namespace VSoft.Company.DQU.DealQuotation.Repository.Services;

public interface IDealQuotationRepository : IEfcRepositoryEntityMgmtId<DealQuotationDbContext, MDealQuotationEntity, long>
{

    string? GetFullName(long? id);

    Task<string?> GetFullNameAsync(long? id);
}
