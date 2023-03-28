using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.UCU.UserCustomer.Data.Db.Contexts;
using VSoft.Company.UCU.UserCustomer.Data.Entity.Models;
using VSoft.Company.UCU.UserCustomer.Repository.Services;

namespace VSoft.Company.UCU.UserCustomer.Repository.Efc.Services;

public interface IUserCustomerRepositoryEfc : IUserCustomerRepository, IEfcRepositoryEntityMgmtId<UserCustomerDbContext, MUserCustomerEntity, int>
{
   
}
