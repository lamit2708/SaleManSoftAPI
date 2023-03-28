using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.CTM.Customer.Data.Db.Contexts;
using VSoft.Company.CTM.Customer.Data.Entity.Models;
using VSoft.Company.CTM.Customer.Repository.Services;

namespace VSoft.Company.CTM.Customer.Repository.Efc.Services;

public interface ICustomerRepositoryEfc : ICustomerRepository, IEfcRepositoryEntityMgmtId<CustomerDbContext, MCustomerEntity, long>
{
    
}
