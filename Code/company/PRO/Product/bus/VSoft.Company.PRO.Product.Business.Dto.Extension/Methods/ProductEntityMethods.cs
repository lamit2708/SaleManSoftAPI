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
            Quantity = src.Quantity,
            CategoryId = src.CategoryId,
            Description = src.Description,
        };
    }
    public static List<ProductDto> GetDto(this List<MProductEntity> srcs)
    {
        var rs = new List<ProductDto>();
        if (srcs == null)
            return rs;
        srcs.ForEach(src => rs.Add(src.GetDto()));
        return rs;
    }
}
