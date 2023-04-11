using VSoft.Company.ACT.Activity.Business.Dto.Data;
using VSoft.Company.ACT.Activity.Data.Entity.Models;

namespace VSoft.Company.ACT.Activity.Business.entity.Extension.Methods;

public static class ActivityEntityMethods
{
    public static ActivityDto GetDto(this MActivityEntity src)
    {
        return new ActivityDto()
        {
            Id = src.Id,
            Name = src.Name,
            Content = src.Content,
            ActivityType = src.ActivityType,
            Date = src.Date,
            From = src.From,
            To = src.To,
            ToWho = src.ToWho,
            SubType = src.SubType,
            CreatedDate = src.CreatedDate,
            CreatedUser = src.CreatedUser,
        };
    }

    public static List<ActivityDto> GetDto(this List<MActivityEntity> srcs)
    {
        var rs = new List<ActivityDto>();
        if (srcs == null)
            return rs;
        srcs.ForEach(src => rs.Add(src.GetDto()));
        return rs;
    }
}
