﻿using VegunSoft.Framework.Paging.Provider.Request;
using VegunSoft.Framework.Paging.Provider.Response;
using VegunSoft.Framework.Repository.Id.Efc.Services;
using VSoft.Company.ACT.Activity.Data.Db.Contexts;
using VSoft.Company.ACT.Activity.Data.Entity.Models;

namespace VSoft.Company.ACT.Activity.Repository.Services;

public interface IActivityRepository : IEfcRepositoryEntityMgmtId<ActivityDbContext, MActivityEntity, int>
{

    string? GetFullName(int? id);

    Task<string?> GetFullNameAsync(int? id);

    Task<PagedList<MActivityEntity>> GetTableByKeySearchAsync(string keySearch, PagingParameters pagParams);
}
