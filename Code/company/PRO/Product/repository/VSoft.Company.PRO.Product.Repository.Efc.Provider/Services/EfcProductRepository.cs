using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VSoft.Company.PRO.Product.Data.Db.Contexts;
using VSoft.Company.PRO.Product.Data.Entity.Models;
using VSoft.Company.PRO.Product.Repository.Efc.Services;
using VegunSoft.Framework.Paging.Provider.Request;
using VegunSoft.Framework.Paging.Provider.Response;
using VegunSoft.Framework.Value.Property.Methods;

namespace VSoft.Company.PRO.Product.Repository.Efc.Provider.Services;

public class EfcProductRepository : EFcRepositoryEntityMgmtId<ProductDbContext, MProductEntity, int>, IProductRepositoryEfc
{

    public EfcProductRepository(ProductDbContext dbContext) : base(dbContext, dbContext.Items)
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
    public Task<List<MProductEntity>> GetByNameAsync(string name)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (string.IsNullOrEmpty(name)) throw new Exception("The name is null");
        return Entities.Where(x => (x.Keyword ?? string.Empty).ToLower().Contains(name.ToLower())).ToListAsync();
    }
    public MProductEntity? UpdateWithKeyword(MProductEntity entity)
    {
        entity.Keyword = CreateKeyword($"{entity.Name} {entity.Description}");
        return base.Update(entity);

    }
    public Task<MProductEntity?> UpdateWithKeywordAsync(MProductEntity entity)
    {
        entity.Keyword = CreateKeyword($"{entity.Name} {entity.Description}");
        return base.UpdateAsync(entity);

    }
    public MProductEntity? CreateWithKeyword(MProductEntity entity)
    {
        entity.Keyword = CreateKeyword($"{entity.Name} {entity.Description}");
        return base.Create(entity);

    }
    public Task<MProductEntity?> CreateWithKeywordAsync(MProductEntity entity)
    {
        entity.Keyword = CreateKeyword($"{entity.Name} {entity.Description}");
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
    public async Task<PagedList<MProductEntity>> GetTableByKeySearchAsync(string keySearch, PagingParameters pagParams)
    {
        IQueryable<MProductEntity>? query;
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
        return new PagedList<MProductEntity>(data, count, pagParams.PageNumber, pagParams.PageSize);
    }
}
