﻿using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Paging.Provider.Request;
using VegunSoft.Framework.Paging.Provider.Response;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VegunSoft.Framework.Value.Property.Methods;
using VSoft.Company.CTM.Customer.Data.Db.Contexts;
using VSoft.Company.CTM.Customer.Data.Entity.Models;
using VSoft.Company.CTM.Customer.Repository.Efc.Services;

namespace VSoft.Company.CTM.Customer.Repository.Efc.Provider.Services;

public class EfcCustomerRepository : EFcRepositoryEntityMgmtId<CustomerDbContext, MCustomerEntity, long>, ICustomerRepositoryEfc
{

    public EfcCustomerRepository(CustomerDbContext dbContext) : base(dbContext, dbContext.Items)
    {

    }
    //public async Task<MCustomerEntity?> CreateAsync(MCustomerEntity entity, string abc)
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
        return Entities.Where(x => x.Id == id).Select(x => x.Name ?? string.Empty).FirstOrDefault();
    }

    public Task<string?> GetFullNameAsync(long? id)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (id == null) throw new Exception("id is null");
        return Entities.Where(x => x.Id == id).Select(x => x.Name ?? string.Empty).FirstOrDefaultAsync() ;
    }

    public Task<List<MCustomerEntity>> GetCustomersByNameAsync(string name)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (string.IsNullOrEmpty(name )) throw new Exception("The name is null");
        return Entities.Where(x => (x.Keyword??string.Empty).ToLower().Contains(name.ToLower())).ToListAsync();
    }
    public MCustomerEntity? UpdateWithKeyword(MCustomerEntity entity)
    {
        entity.Keyword = CreateKeyword($"{entity.Name} {entity.Phone} {entity.Email} {entity.Address}");
        return base.Update(entity);

    }
    public MCustomerEntity? CreateWithKeyword(MCustomerEntity entity)
    {
        entity.Keyword = CreateKeyword($"{entity.Name} {entity.Phone} {entity.Email} {entity.Address}");
        return base.Create(entity);

    }

    public Task<MCustomerEntity?> UpdateWithKeywordAsync(MCustomerEntity entity)
    {
        entity.Keyword = CreateKeyword($"{entity.Name} {entity.Phone} {entity.Email} {entity.Address}");
        return base.UpdateAsync(entity);

    }
 
    public Task<MCustomerEntity?> CreateWithKeywordAsync(MCustomerEntity entity)
    {
        entity.Keyword = CreateKeyword($"{entity.Name} {entity.Phone} {entity.Email} {entity.Address}");
        return base.CreateAsync(entity);

    }

    private string? CreateKeyword(string v)
    {
        return RemoveSign4VietnameseString(v);
    }
    private static readonly string[] VietnameseSigns = new string[]

   {

        "aAeEoOuUiIdDyY",

        "áàạảãâấầậẩẫăắằặẳẵ",

        "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",

        "éèẹẻẽêếềệểễ",

        "ÉÈẸẺẼÊẾỀỆỂỄ",

        "óòọỏõôốồộổỗơớờợởỡ",

        "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",

        "úùụủũưứừựửữ",

        "ÚÙỤỦŨƯỨỪỰỬỮ",

        "íìịỉĩ",

        "ÍÌỊỈĨ",

        "đ",

        "Đ",

        "ýỳỵỷỹ",

        "ÝỲỴỶỸ"

   };



    public static string RemoveSign4VietnameseString(string str)

    {

        //Tiến hành thay thế , lọc bỏ dấu cho chuỗi

        for (int i = 1; i < VietnameseSigns.Length; i++)

        {

            for (int j = 0; j < VietnameseSigns[i].Length; j++)

                str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);

        }

        return str;

    }
    public async Task<PagedList<MCustomerEntity>> GetTableByKeySearchAsync(string keySearch, PagingParameters pagParams)
    {
        IQueryable<MCustomerEntity>? query;
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
        return new PagedList<MCustomerEntity>(data, count, pagParams.PageNumber, pagParams.PageSize);
    }

}
