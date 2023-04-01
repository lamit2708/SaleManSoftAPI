using VSoft.Company.TEA.Team.Business.Dto.Data;
using VSoft.Company.TEA.Team.Data.Entity.Models;

namespace VSoft.Company.TEA.Team.Business.entity.Extension.Methods;

public static class TeamEntityMethods
{
    public static TeamDto GetDto(this MTeamEntity src)
    {
        return new TeamDto()
        {
            Id = src.Id,
            Name = src.Name,
            Description = src.Description,
        };
    }

    public static List<TeamDto> GetDto(this List<MTeamEntity> srcs)
    {
        var rs = new List<TeamDto>();
        if (srcs == null)
            return rs;
        srcs.ForEach(src => rs.Add(src.GetDto()));
        return rs;
    }
}
