using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.CIN.CustomerInfo.Data.Db.Contexts;
using VSoft.Company.CIN.CustomerInfo.Data.Entity.Models;
using VSoft.Company.CIN.CustomerInfo.Repository.Services;

namespace VSoft.Company.CIN.CustomerInfo.Repository.Efc.Services;

public interface ICustomerInfoRepositoryEfc : ICustomerInfoRepository, IEfcRepositoryEntityMgmtId<CustomerInfoDbContext, MCustomerInfoEntity, long>
{
   
}
