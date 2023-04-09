using VSoft.Company.DEA.Deal.Business.Dto.Data;
using VSoft.Company.DEA.Deal.Data.Entity.Models;

namespace VSoft.Company.DEA.Deal.Business.entity.Extension.Methods;

public static class DealEntityMethods
{
    public static DealDto GetDto(this MDealEntity src)
    {
        return new DealDto()
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

    public static List<DealDto> GetDto(this List<MDealEntity> srcs)
    {
        var rs = new List<DealDto>();
        if (srcs == null)
            return rs;
        srcs.ForEach(src => rs.Add(src.GetDto()));
        return rs;
    }
}
