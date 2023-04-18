using VSoft.Company.VDT.VDealTag.Business.Dto.Data;
using VSoft.Company.VDT.VDealTag.Data.Entity.Models;

namespace VSoft.Company.VDT.VDealTag.Business.Dto.Extension.Methods;

public static class VDealTagDtoMethods
{
    public static MVDealTagEntity GetEntity(this VDealTagDto src, bool isForUpdate)
    {
        return new MVDealTagEntity()
        {
            Id = src.Id,
            DealName = src.DealName,
            CustomerId = src.CustomerId,
            CustomerName = src.CustomerName,
            CustomerPhone = src.CustomerPhone,
            PridictPrice = src.PridictPrice,
            DealStepId = src.DealStepId
        };
    }
}
