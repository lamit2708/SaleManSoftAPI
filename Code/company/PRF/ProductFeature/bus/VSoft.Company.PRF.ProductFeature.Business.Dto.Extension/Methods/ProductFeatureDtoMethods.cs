using VSoft.Company.PRF.ProductFeature.Business.Dto.Data;
using VSoft.Company.PRF.ProductFeature.Data.Entity.Models;

namespace VSoft.Company.PRF.ProductFeature.Business.Dto.Extension.Methods;

public static class ProductFeatureDtoMethods
{
    public static MProductFeatureEntity GetEntity(this ProductFeatureDto src, bool isForUpdate)
    {
        return new MProductFeatureEntity()
        {
            Id = src.Id,
            Name = src.Name,
            Description = src.Description,
        };
    }
}
