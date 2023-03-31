using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VegunSoft.Framework.Paging.Provider.Request;
using VegunSoft.Framework.Paging.Provider.Response;
using VSoft.Company.TEA.Team.Business.Dto.Data;
using VSoft.Company.TEA.Team.Business.Dto.Request;
using VSoft.Company.TEA.Team.Business.Dto.Response;

namespace VSoft.Company.TEA.Team.Client.Services;

public interface ITeamClient: IApiDtoClientJSon<ITeamClient>
{
    Task<MDtoResponse<PagedList<TeamDto>>> GetTableByKeyword(string keyWord, PagingParameters pageParameter);

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