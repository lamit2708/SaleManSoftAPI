using VSoft.Company.TEA.Team.Business.Dto.Data;
using VSoft.Company.TEA.Team.Data.Entity.Models;

namespace VSoft.Company.TEA.Team.Business.Dto.Extension.Methods;

public static class TeamDtoMethods
{
    public static MTeamEntity GetEntity(this TeamDto src, bool isForUpdate)
    {
        return new MTeamEntity()
        {
            Id = src.Id,
            Name = src.Name,
            Description = src.Description,
        };
    }
}
