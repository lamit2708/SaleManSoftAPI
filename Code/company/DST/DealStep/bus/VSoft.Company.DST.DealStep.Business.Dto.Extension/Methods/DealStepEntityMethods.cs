using VSoft.Company.DST.DealStep.Business.Dto.Data;
using VSoft.Company.DST.DealStep.Data.Entity.Models;

namespace VSoft.Company.DST.DealStep.Business.entity.Extension.Methods;

public static class DealStepEntityMethods
{
    public static DealStepDto GetDto(this MDealStepEntity src)
    {
        return new DealStepDto()
        {
            Id = src.Id,
            Name = src.Name,
            Description = src.Description
        };
    }

    public static List<DealStepDto> GetDto(this List<MDealStepEntity> srcs)
    {
        var rs = new List<DealStepDto>();
        if (srcs == null)
            return rs;
        srcs.ForEach(src => rs.Add(src.GetDto()));
        return rs;
    }
}
