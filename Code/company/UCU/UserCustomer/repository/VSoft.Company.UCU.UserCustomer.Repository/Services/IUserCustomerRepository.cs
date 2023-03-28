using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.UCU.UserCustomer.Data.Db.Contexts;
using VSoft.Company.UCU.UserCustomer.Data.Entity.Models;

namespace VSoft.Company.UCU.UserCustomer.Repository.Services;

public interface IUserCustomerRepository : IEfcRepositoryEntityMgmtId<UserCustomerDbContext, MUserCustomerEntity, int>
{

    string? GetFullName(int? id);

    Task<string?> GetFullNameAsync(int? id);
}
