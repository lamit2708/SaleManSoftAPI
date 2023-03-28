using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.CSO.CustomerSource.Data.Db.Contexts;
using VSoft.Company.CSO.CustomerSource.Data.Entity.Models;
using VSoft.Company.CSO.CustomerSource.Repository.Services;

namespace VSoft.Company.CSO.CustomerSource.Repository.Efc.Services;

public interface ICustomerSourceRepositoryEfc : ICustomerSourceRepository, IEfcRepositoryEntityMgmtId<CustomerSourceDbContext, MCustomerSourceEntity, int>
{
   
}
