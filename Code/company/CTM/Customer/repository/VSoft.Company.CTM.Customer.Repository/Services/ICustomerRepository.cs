using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.CTM.Customer.Data.Db.Contexts;
using VSoft.Company.CTM.Customer.Data.Entity.Models;

namespace VSoft.Company.CTM.Customer.Repository.Services;

public interface ICustomerRepository : IEfcRepositoryEntityMgmtId<CustomerDbContext, MCustomerEntity, long>
{

    string? GetFullName(long? id);

    Task<string?> GetFullNameAsync(long? id);

    Task<List<MCustomerEntity>> GetCustomersByNameAsync(string name);

    MCustomerEntity? CreateWithKeyword(MCustomerEntity entity);

    MCustomerEntity? UpdateWithKeyword(MCustomerEntity entity);

}
