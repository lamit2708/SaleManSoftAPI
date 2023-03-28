using Microsoft.EntityFrameworkCore;
using VegunSoft.Framework.Repository.Id.Efc.Provider.Services;
using VSoft.Company.PRC.ProductCategory.Data.Db.Contexts;
using VSoft.Company.PRC.ProductCategory.Data.Entity.Models;
using VSoft.Company.PRC.ProductCategory.Repository.Efc.Services;

namespace VSoft.Company.PRC.ProductCategory.Repository.Efc.Provider.Services;

public class EfcProductCategoryRepository : EFcRepositoryEntityMgmtId<ProductCategoryDbContext, MProductCategoryEntity, int>, IProductCategoryRepositoryEfc
{

    public EfcProductCategoryRepository(ProductCategoryDbContext dbContext) : base(dbContext, dbContext.Items)
    {

    }
    //public async Task<MProductCategoryEntity?> CreateAsync(MProductCategoryEntity entity, string abc)
    //{
    //    if (DbContext == null) throw new Exception("_context is null");
    //    if (Entities == null) throw new Exception("EntitySet is null");
    //    await Entities.AddAsync(entity);
    //    await DbContext.SaveChangesAsync();
    //    return entity;
    //}
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
        return Entities.Where(x => x.Id == id).Select(x => x.Name ?? string.Empty).FirstOrDefaultAsync();
    }

    public Task<List<MProductCategoryEntity>> GetProductCategorysByNameAsync(string name)
    {
        if (DbContext == null) throw new Exception("Context is null");
        if (Entities == null) throw new Exception("Entities is null");
        if (string.IsNullOrEmpty(name)) throw new Exception("The name is null");
        //return Entities.Where(x => (x.Keyword ?? string.Empty).ToLower().Contains(name.ToLower())).ToListAsync();
        return Entities.Where(x => (x.Name ?? string.Empty).ToLower().Contains(name.ToLower())).ToListAsync();
    }
    //public MProductCategoryEntity? UpdateWithKeyword(MProductCategoryEntity entity)
    //{
    //    entity.Keyword = CreateKeyword($"{entity.Name} {entity.Phone} {entity.Email}");
    //    return base.Update(entity);

    //}
    //public MProductCategoryEntity? CreateWithKeyword(MProductCategoryEntity entity)
    //{
    //    entity.Keyword = CreateKeyword($"{entity.Name} {entity.Phone} {entity.Email}");
    //    return base.Create(entity);

    //}

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


}
