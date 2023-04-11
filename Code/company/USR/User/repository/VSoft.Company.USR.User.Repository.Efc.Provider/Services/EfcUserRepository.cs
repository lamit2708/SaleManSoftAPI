using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Paging.Provider.Request;
using VegunSoft.Framework.Paging.Provider.Response;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VegunSoft.Framework.Value.Property.Methods;
using VSoft.Company.USR.User.Data.Db.Contexts;
using VSoft.Company.USR.User.Data.Entity.Models;
using VSoft.Company.USR.User.Repository.Efc.Services;

namespace VSoft.Company.USR.User.Repository.Efc.Provider.Services;

public class EfcUserRepository : EFcRepositoryEntityMgmtId<UserDbContext, MUserEntity, int>, IUserRepositoryEfc
{

    public EfcUserRepository(UserDbContext dbContext) : base(dbContext, dbContext.Items)
    {

    }

    public string? GetFullName(int? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.Name ?? string.Empty).FirstOrDefault();
    }

    public Task<string?> GetFullNameAsync(int? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.Name ?? string.Empty).FirstOrDefaultAsync() ;
    }

    public async Task<PagedList<MUserEntity>> GetTableByKeySearchAsync(string keySearch, PagingParameters pagParams)
    {
        IQueryable<MUserEntity>? query;
        if (string.IsNullOrEmpty(keySearch))
            query = Entities;
        else
        {
            var unsignedKey = keySearch.ConvertToUnsignedString();
            //query = Entities.Where(x => x.Name.ConvertToUnsignedString().Contains(unsignedKey));
            query = Entities.Where(x => x.Name.Contains(keySearch));
        }

        var count = await query.CountAsync();

        var data = await query
            .Skip((pagParams.PageNumber - 1) * pagParams.PageSize)
            .Take(pagParams.PageSize)
            .ToListAsync();
        return new PagedList<MUserEntity>(data, count, pagParams.PageNumber, pagParams.PageSize);
    }
}
