using VSoft.Company.DQU.DealQuotation.Business.Dto.Data;
using VSoft.Company.DQU.DealQuotation.Data.Entity.Models;

namespace VSoft.Company.DQU.DealQuotation.Business.Dto.Extension.Methods;

public static class DealQuotationDtoMethods
{
    public static MDealQuotationEntity GetEntity(this DealQuotationDto src, bool isForUpdate)
    {
        return new MDealQuotationEntity()
        {
            Id = src.Id,
            DealId = src.DealId,
            ProductId = src.ProductId,
            Quatitty = src.Quatitty,
            UserId  = src.UserId,
            CreatedDate = src.CreatedDate,
        };
    }
}
