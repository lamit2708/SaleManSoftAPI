using VSoft.Company.DSH.DealStepHistory.Business.Dto.Data;
using VSoft.Company.DSH.DealStepHistory.Data.Entity.Models;

namespace VSoft.Company.DSH.DealStepHistory.Business.entity.Extension.Methods;

public static class DealStepHistoryEntityMethods
{
    public static DealStepHistoryDto GetDto(this MDealStepHistoryEntity src)
    {
        return new DealStepHistoryDto()
        {
            Id = src.Id,
            DealStepId = src.DealStepId,
            DateTime = src.DateTime,
            UserId = src.UserId,
        };
    }
}
