using VSoft.Company.DSH.DealStepHistory.Business.Dto.Data;
using VSoft.Company.DSH.DealStepHistory.Data.Entity.Models;

namespace VSoft.Company.DSH.DealStepHistory.Business.Dto.Extension.Methods;

public static class DealStepHistoryDtoMethods
{
    public static MDealStepHistoryEntity GetEntity(this DealStepHistoryDto src, bool isForUpdate)
    {
        return new MDealStepHistoryEntity()
        {
            Id = src.Id,
            DealStepId = src.DealStepId,
            DateTime = src.DateTime,
            UserId = src.UserId,
        };
    }
}
