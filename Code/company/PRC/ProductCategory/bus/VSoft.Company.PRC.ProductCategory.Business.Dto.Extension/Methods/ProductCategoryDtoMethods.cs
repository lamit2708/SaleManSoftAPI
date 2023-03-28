using VSoft.Company.PRC.ProductCategory.Business.Dto.Data;
using VSoft.Company.PRC.ProductCategory.Data.Entity.Models;

namespace VSoft.Company.PRC.ProductCategory.Business.Dto.Extension.Methods;

public static class ProductCategoryDtoMethods
{
    public static MProductCategoryEntity GetEntity(this ProductCategoryDto src, bool isForUpdate)
    {
        return new MProductCategoryEntity()
        {
            Id = src.Id,
            Name = src.Name,
           
        };
    }
}
