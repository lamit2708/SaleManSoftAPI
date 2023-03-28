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
}
