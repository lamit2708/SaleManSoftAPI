using VSoft.Company.VDT.VDealTag.Business.Dto.Data;
using VSoft.Company.VDT.VDealTag.Data.Entity.Models;

namespace VSoft.Company.VDT.VDealTag.Business.entity.Extension.Methods;

public static class VDealTagEntityMethods
{
    public static VDealTagDto GetDto(this MVDealTagEntity src)
    {
        return new VDealTagDto()
        {
            Id = src.Id,
            DealName = src.DealName,
            CustomerId = src.CustomerId,
            CustomerName = src.CustomerName,
            CustomerPhone = src.CustomerPhone,
            PridictPrice = src.PridictPrice,
            DealStepId = src.DealStepId,
            UserId = src.UserId,
            UserName = src.UserName,
            TeamId = src.TeamId,
            DateFor = src.DateFor,
        };
    }
    public static List<VDealTagDto> GetDto(this List<MVDealTagEntity> srcs)
    {
        var rs = new List<VDealTagDto>();
        if (srcs == null)
            return rs;
        srcs.ForEach(src => rs.Add(src.GetDto()));
        return rs;
    }
}
