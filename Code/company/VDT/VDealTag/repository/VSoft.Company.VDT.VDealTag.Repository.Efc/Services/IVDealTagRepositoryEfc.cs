using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.VDT.VDealTag.Data.Db.Contexts;
using VSoft.Company.VDT.VDealTag.Data.Entity.Models;
using VSoft.Company.VDT.VDealTag.Repository.Services;

namespace VSoft.Company.VDT.VDealTag.Repository.Efc.Services;

public interface IVDealTagRepositoryEfc : IVDealTagRepository, IEfcRepositoryEntityReadOnlyId<VDealTagDbContext, MVDealTagEntity, long>
{
    
}
