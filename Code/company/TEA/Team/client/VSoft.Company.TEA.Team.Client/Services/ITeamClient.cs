using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.TEA.Team.Business.Dto.Request;
using VSoft.Company.TEA.Team.Business.Dto.Response;

namespace VSoft.Company.TEA.Team.Client.Services;

public interface ITeamClient: IApiDtoClientJSon<ITeamClient>
{  

    Task<TeamFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<TeamFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<TeamInsertDtoResponse> CreateAsync(TeamInsertDtoRequest request);

    Task<TeamInsertRangeDtoResponse> CreateRangeAsync(TeamInsertRangeDtoRequest request);

    Task<TeamUpdateDtoResponse> UpdateAsync(TeamUpdateDtoRequest request);

    Task<TeamUpdateRangeDtoResponse> UpdateRangeAsync(TeamUpdateRangeDtoRequest request);

    Task<TeamDeleteDtoResponse> DeleteAsync(TeamDeleteDtoRequest request);

    Task<TeamDeleteRangeDtoResponse> DeleteRangeAsync(TeamDeleteRangeDtoRequest request);

    Task<TeamSaveRangeDtoResponse> SaveRangeAsync(TeamSaveRangeDtoRequest request);
   
}