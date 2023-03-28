using VSoft.Company.DAC.DealActivity.Business.Dto.Data;
using VSoft.Company.DAC.DealActivity.Data.Entity.Models;

namespace VSoft.Company.DAC.DealActivity.Business.entity.Extension.Methods;

public static class DealActivityEntityMethods
{
    public static DealActivityDto GetDto(this MDealActivityEntity src)
    {
        return new DealActivityDto()
        {
            Id = src.Id,
            DealId = src.DealId,
            ActivityId = src.ActivityId,
            Subject = src.Subject,
            Content = src.Content,
            CreatedDate = src.CreatedDate,
            UserId = src.UserId,
        };
    }
}
