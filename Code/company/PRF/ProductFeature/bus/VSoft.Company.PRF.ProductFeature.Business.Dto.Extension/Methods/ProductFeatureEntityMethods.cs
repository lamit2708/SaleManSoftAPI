using VSoft.Company.PRF.ProductFeature.Business.Dto.Data;
using VSoft.Company.PRF.ProductFeature.Data.Entity.Models;

namespace VSoft.Company.PRF.ProductFeature.Business.entity.Extension.Methods;

public static class ProductFeatureEntityMethods
{
    public static ProductFeatureDto GetDto(this MProductFeatureEntity src)
    {
        return new ProductFeatureDto()
        {
            Id = src.Id,
            Name = src.Name,
            Description = src.Description,
            ProductId = src.ProductId,
            Price = src.Price,
        };
    }

    public static List<ProductFeatureDto> GetDto(this List<MProductFeatureEntity> srcs)
    {
        var rs = new List<ProductFeatureDto>();
        if (srcs == null)
            return rs;
        srcs.ForEach(src => rs.Add(src.GetDto()));
        return rs;
    }
}
