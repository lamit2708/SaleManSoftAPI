using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VegunSoft.Framework.Paging.Provider.Request;
using VegunSoft.Framework.Paging.Provider.Response;
using VSoft.Company.TEA.Team.Business.Dto.Data;
using VSoft.Company.TEA.Team.Business.Dto.Request;
using VSoft.Company.TEA.Team.Business.Dto.Response;

namespace VSoft.Company.TEA.Team.Business.Services;

public interface ITeamMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByInt request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByInt request);

    TeamFindDtoResponse Find(MDtoRequestFindByInt request);

    Task<TeamFindDtoResponse> FindAsync(MDtoRequestFindByInt request);

    TeamFindRangeDtoResponse FindRange(MDtoRequestFindRangeByInts request);

    Task<TeamFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByInts request);

    TeamInsertDtoResponse Create(TeamInsertDtoRequest request);

    Task<TeamInsertDtoResponse> CreateAsync(TeamInsertDtoRequest request);

    TeamInsertRangeDtoResponse CreateRange(TeamInsertRangeDtoRequest request);

    Task<TeamInsertRangeDtoResponse> CreateRangeAsync(TeamInsertRangeDtoRequest request);

    TeamUpdateDtoResponse Update(TeamUpdateDtoRequest request);

    Task<TeamUpdateDtoResponse> UpdateAsync(TeamUpdateDtoRequest request);

    TeamUpdateRangeDtoResponse UpdateRange(TeamUpdateRangeDtoRequest request);

    Task<TeamUpdateRangeDtoResponse> UpdateRangeAsync(TeamUpdateRangeDtoRequest request);

    TeamDeleteDtoResponse Delete(TeamDeleteDtoRequest request);

    Task<TeamDeleteDtoResponse> DeleteAsync(TeamDeleteDtoRequest request);

    TeamDeleteRangeDtoResponse DeleteRange(TeamDeleteRangeDtoRequest request);

    Task<TeamDeleteRangeDtoResponse> DeleteRangeAsync(TeamDeleteRangeDtoRequest request);

    Task<TeamSaveRangeDtoResponse> SaveRangeAsync(TeamSaveRangeDtoRequest request);

    Task<TeamSaveRangeDtoResponse> SaveRangeTransactionAsync(TeamSaveRangeDtoRequest request);

    Task<TeamTableKeySearchDtoResponse> GetTableByKeySearch(TeamTableKeySearchDtoRequest request);

    Task<TeamKeyValueResponse> GetAll();
}
