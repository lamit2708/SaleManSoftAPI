using VSoft.Company.DQU.DealQuotation.Business.Dto.Data;
using VSoft.Company.DQU.DealQuotation.Data.Entity.Models;

namespace VSoft.Company.DQU.DealQuotation.Business.entity.Extension.Methods;

public static class DealQuotationEntityMethods
{
    public static DealQuotationDto GetDto(this MDealQuotationEntity src)
    {
        return new DealQuotationDto()
        {
            Id = src.Id,
            DealId = src.DealId,
            ProductId = src.ProductId,
            Quatitty = src.Quatitty,
            UserId = src.UserId,
            CreatedDate = src.CreatedDate,
        };
    }
}
