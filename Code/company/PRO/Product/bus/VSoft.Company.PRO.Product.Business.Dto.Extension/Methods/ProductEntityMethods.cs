using VSoft.Company.PRO.Product.Business.Dto.Data;
using VSoft.Company.PRO.Product.Data.Entity.Models;

namespace VSoft.Company.PRO.Product.Business.entity.Extension.Methods;

public static class ProductEntityMethods
{
    public static ProductDto GetDto(this MProductEntity src)
    {
        return new ProductDto()
        {
            Id = src.Id,
            Name = src.Name,
            Price = src.Price,
            Quatity = src.Quatity,
            Category = src.Category,
            Description = src.Description,
        };
    }
}
