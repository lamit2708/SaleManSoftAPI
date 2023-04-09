using VSoft.Company.DEA.Deal.Business.Dto.Data;
using VSoft.Company.DEA.Deal.Data.Entity.Models;

namespace VSoft.Company.DEA.Deal.Business.Dto.Extension.Methods;

public static class DealDtoMethods
{
    public static MDealEntity GetEntity(this DealDto src, bool isForUpdate)
    {
        return new MDealEntity()
        {
            Id = src.Id,
            CreatedDate = src.CreatedDate,
            CustomerId = src.CustomerId,
            DealStepId = src.DealStepId,
            UserId = src.UserId,
            OrderId = src.OrderId,
            Name = src.Name,
            Description = src.Description,
            PridictPrice = src.PridictPrice,
            DateFor = src.DateFor,
            PricePossible = src.PricePossible,
        };
    }
}
