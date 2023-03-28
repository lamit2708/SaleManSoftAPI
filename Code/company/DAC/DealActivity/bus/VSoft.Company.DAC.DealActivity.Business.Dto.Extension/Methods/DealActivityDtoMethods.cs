using VSoft.Company.DAC.DealActivity.Business.Dto.Data;
using VSoft.Company.DAC.DealActivity.Data.Entity.Models;

namespace VSoft.Company.DAC.DealActivity.Business.Dto.Extension.Methods;

public static class DealActivityDtoMethods
{
    public static MDealActivityEntity GetEntity(this DealActivityDto src, bool isForUpdate)
    {
        return new MDealActivityEntity()
        {
            Id = src.Id,
            DealId = src.DealId,
            ActivityId = src.ActivityId,
            Subject = src.Subject,
            Content = src.Content,
            CreatedDate = src.CreatedDate,
            UserId  = src.UserId,
        };
    }
}
