using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Paging.Provider.Request;
using VegunSoft.Framework.Paging.Provider.Response;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VSoft.Company.UCU.UserCustomer.Data.Db.Contexts;
using VSoft.Company.UCU.UserCustomer.Data.Entity.Models;
using VSoft.Company.UCU.UserCustomer.Repository.Efc.Services;

namespace VSoft.Company.UCU.UserCustomer.Repository.Efc.Provider.Services;

public class EfcUserCustomerRepository : EFcRepositoryEntityMgmtId<UserCustomerDbContext, MUserCustomerEntity, int, MUserCustomerViewEntity>, IUserCustomerRepositoryEfc
{

    public EfcUserCustomerRepository(UserCustomerDbContext dbContext) : base(dbContext, dbContext.Items, dbContext.ViewItems)
    {

    }

    public string? GetFullName(int? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.CustomerId.ToString() ?? string.Empty).FirstOrDefault();
    }

    public Task<string?> GetFullNameAsync(int? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.CustomerId.ToString() ?? string.Empty).FirstOrDefaultAsync() ;
    }

    public async Task<PagedList<MUserCustomerViewEntity>> GetViewEntitiesByKeySearchAsync(string keySearch, PagingParameters pagParams)
    {
        IQueryable<MUserCustomerViewEntity>? query;
        if (string.IsNullOrEmpty(keySearch))
            query = ViewEntities;
        else
        {
            if (ViewEntities == null) return new PagedList<MUserCustomerViewEntity>();
            //var unsignedKey = keySearch.ConvertToUnsignedString();
            //query = Entities.Where(x => x.Name.ConvertToUnsignedString().Contains(unsignedKey));
            query = ViewEntities.Where(x => 
            x.CustomerFullName != null && x.CustomerFullName.Contains(keySearch)
            || x.UserFullName != null && x.UserFullName.Contains(keySearch)
            || x.TeamName != null && x.TeamName.Contains(keySearch)
            );
        }
        if (query == null) return new PagedList<MUserCustomerViewEntity>();
        var count = await query.CountAsync();

        var data = await query
            .Skip((pagParams.PageNumber - 1) * pagParams.PageSize)
            .Take(pagParams.PageSize)
            .ToListAsync();
        return new PagedList<MUserCustomerViewEntity>(data, count, pagParams.PageNumber, pagParams.PageSize);
    }
}
