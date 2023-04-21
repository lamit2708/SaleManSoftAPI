using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Paging.Provider.Request;
using VegunSoft.Framework.Paging.Provider.Response;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VegunSoft.Framework.Value.Property.Methods;
using VSoft.Company.DEA.Deal.Data.Db.Contexts;
using VSoft.Company.DEA.Deal.Data.Entity.Models;
using VSoft.Company.DEA.Deal.Repository.Efc.Services;

namespace VSoft.Company.DEA.Deal.Repository.Efc.Provider.Services;

public class EfcDealRepository : EFcRepositoryEntityMgmtId<DealDbContext, MDealEntity, long, MDealViewEntity>, IDealRepositoryEfc
{
 
    public EfcDealRepository(DealDbContext dbContext) : base(dbContext, dbContext.Items, dbContext.ViewItems)
    {
       
    }

    public async Task<PagedList<MDealViewEntity>> GetViewEntitiesByKeySearchAsync(string keySearch, PagingParameters pagParams)
    {
        IQueryable<MDealViewEntity>? query;
        if (string.IsNullOrEmpty(keySearch))
            query = ViewEntities;
        else
        {
            if (ViewEntities == null) return new PagedList<MDealViewEntity>();
            //var unsignedKey = keySearch.ConvertToUnsignedString();
            //query = Entities.Where(x => x.Name.ConvertToUnsignedString().Contains(unsignedKey));
            query = ViewEntities.Where(x => x.Name != null && x.Name.Contains(keySearch));
        }
        if (query == null) return new PagedList<MDealViewEntity>();
        var count = await query.CountAsync();

        var data = await query
            .Skip((pagParams.PageNumber - 1) * pagParams.PageSize)
            .Take(pagParams.PageSize)
            .ToListAsync();
        return new PagedList<MDealViewEntity>(data, count, pagParams.PageNumber, pagParams.PageSize);
    }

    public string? GetFullName(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.Name ?? string.Empty).FirstOrDefault();
    }

    public Task<string?> GetFullNameAsync(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.Name ?? string.Empty).FirstOrDefaultAsync() ;
    }

    public async Task<PagedList<MDealEntity>> GetTableByKeySearchAsync(string keySearch, PagingParameters pagParams)
    {
        IQueryable<MDealEntity>? query;
        if (string.IsNullOrEmpty(keySearch))
            query = Entities;
        else
        {
            //var unsignedKey = keySearch.ConvertToUnsignedString();
            //query = Entities.Where(x => x.Name.ConvertToUnsignedString().Contains(unsignedKey));
            query = Entities.Where(x => x.Name.Contains(keySearch));
        }

        var count = await query.CountAsync();

        var data = await query
            .Skip((pagParams.PageNumber - 1) * pagParams.PageSize)
            .Take(pagParams.PageSize)
            .ToListAsync();
        return new PagedList<MDealEntity>(data, count, pagParams.PageNumber, pagParams.PageSize);
    }
}
