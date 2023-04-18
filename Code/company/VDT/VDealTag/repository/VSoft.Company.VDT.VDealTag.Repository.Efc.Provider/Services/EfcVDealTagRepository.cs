using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Paging.Provider.Request;
using VegunSoft.Framework.Paging.Provider.Response;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VegunSoft.Framework.Value.Property.Methods;
using VSoft.Company.VDT.VDealTag.Data.Db.Contexts;
using VSoft.Company.VDT.VDealTag.Data.Entity.Models;
using VSoft.Company.VDT.VDealTag.Repository.Efc.Services;

namespace VSoft.Company.VDT.VDealTag.Repository.Efc.Provider.Services;

public class EfcVDealTagRepository : EfcRepositoryEntityReadOnlyId<VDealTagDbContext, MVDealTagEntity, long>, IVDealTagRepositoryEfc
{

    public EfcVDealTagRepository(VDealTagDbContext dbContext) : base(dbContext, dbContext.Items)
    {

    }
    //public async Task<MVDealTagEntity?> CreateAsync(MVDealTagEntity entity, string abc)
    //{
    //    if (DbContext == null) throw new Exception("_context is null");
    //    if (Entities == null) throw new Exception("EntitySet is null");
    //    await Entities.AddAsync(entity);
    //    await DbContext.SaveChangesAsync();
    //    return entity;
    //}
    public string? GetFullName(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.CustomerName ?? string.Empty).FirstOrDefault();
    }

    public Task<string?> GetFullNameAsync(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.CustomerName ?? string.Empty).FirstOrDefaultAsync() ;
    }

    public Task<List<MVDealTagEntity>> GetVDealTagsByNameAsync(string name)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (string.IsNullOrEmpty(name )) throw new Exception("The name is null");
        return Entities.Where(x => (x.CustomerName??string.Empty).ToLower().Contains(name.ToLower())).ToListAsync();
    }

    public async Task<PagedList<MVDealTagEntity>> GetTableByKeySearchAsync(string keySearch, PagingParameters pagParams)
    {
        IQueryable<MVDealTagEntity>? query;
        if (string.IsNullOrEmpty(keySearch))
            query = Entities;
        else
        {
            var unsignedKey = keySearch.ConvertToUnsignedString();
            //query = Entities.Where(x => x.Name.ConvertToUnsignedString().Contains(unsignedKey));
            query = Entities.Where(x => x.CustomerName.Contains(keySearch));
        }

        var count = await query.CountAsync();

        var data = await query
            .Skip((pagParams.PageNumber - 1) * pagParams.PageSize)
            .Take(pagParams.PageSize)
            .ToListAsync();
        return new PagedList<MVDealTagEntity>(data, count, pagParams.PageNumber, pagParams.PageSize);
    }

    public async Task<List<MVDealTagEntity>> GetAllDealTagByFilter(int? userId, int? teamId, DateTime date, string? keyword)
    {
        var query = Entities;
        if (userId != null)
            query = query.Where(x => x.UserId  == userId);
    }
}
