using VSoft.Company.DST.DealStep.Business.Dto.Data;
using VSoft.Company.DST.DealStep.Data.Entity.Models;

namespace VSoft.Company.DST.DealStep.Business.Dto.Extension.Methods;

public static class DealStepDtoMethods
{
    public static MDealStepEntity GetEntity(this DealStepDto src, bool isForUpdate)
    {
        return new MDealStepEntity()
        {
            Id = src.Id,
            Name = src.Name,
            Description = src.Description
        };
    }
}
