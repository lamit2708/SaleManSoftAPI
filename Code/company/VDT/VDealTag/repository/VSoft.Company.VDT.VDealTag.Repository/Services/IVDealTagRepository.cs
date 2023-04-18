using VegunSoft.Framework.Paging.Provider.Request;
using VegunSoft.Framework.Paging.Provider.Response;
using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.VDT.VDealTag.Data.Db.Contexts;
using VSoft.Company.VDT.VDealTag.Data.Entity.Models;

namespace VSoft.Company.VDT.VDealTag.Repository.Services;

public interface IVDealTagRepository : IEfcRepositoryEntityReadOnlyId<VDealTagDbContext, MVDealTagEntity, long>
{

    string? GetFullName(long? id);

    Task<string?> GetFullNameAsync(long? id);

    Task<List<MVDealTagEntity>> GetVDealTagsByNameAsync(string name);

    Task<PagedList<MVDealTagEntity>> GetTableByKeySearchAsync(string keySearch, PagingParameters pagParams);

    Task<List<MVDealTagEntity>> GetAllDealTagByFilter(int? userId, int? teamId, DateTime date, string? keyword);
}
