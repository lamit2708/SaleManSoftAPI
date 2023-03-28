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
            Name = src.Name,
            CreatedDate = src.CreatedDate,
            DealId = src.DealId,
            DealStepId = src.DealStepId,
            UserId = src.UserId,
            OrderId = src.OrderId,
            Description = src.Description,
        };
    }
}
