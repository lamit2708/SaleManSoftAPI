using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.DQU.DealQuotation.Data.Db.Contexts;
using VSoft.Company.DQU.DealQuotation.Data.Entity.Models;
using VSoft.Company.DQU.DealQuotation.Repository.Services;

namespace VSoft.Company.DQU.DealQuotation.Repository.Efc.Services;

public interface IDealQuotationRepositoryEfc : IDealQuotationRepository, IEfcRepositoryEntityMgmtId<DealQuotationDbContext, MDealQuotationEntity, long>
{
   
}
