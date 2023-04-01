using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VegunSoft.Framework.Paging.Provider.Request;
using VegunSoft.Framework.Paging.Provider.Response;
using VSoft.Company.TEA.Team.Api.Cfg.Routes;
using VSoft.Company.TEA.Team.Business.Dto.Data;
using VSoft.Company.TEA.Team.Business.Dto.Request;
using VSoft.Company.TEA.Team.Business.Dto.Response;
using VSoft.Company.TEA.Team.Client.Models;
using VSoft.Company.TEA.Team.Client.Services;

namespace VSoft.Company.TEA.Team.Client.Provider.Services;

public class TeamClient : ApiDtoClientJSon<ITeamClient, MTeamClient>, ITeamClient
{
    public TeamClient(IConfigurationRoot configuration, MTeamClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
        BaseAddress = "https://localhost:7174/";
    }

    public override string Controller { get; } = nameof(ITeamControllerPath.Team);

    public Task<TeamTableKeySearchDtoResponse> GetTableByKeyword(TeamTableKeySearchDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ITeamActionName.FindRange));
        return GetAsync<TeamTableKeySearchDtoRequest, TeamTableKeySearchDtoResponse>(relativePath, request);
    }

    public Task<TeamFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(ITeamActionName.FindOne));
        return GetAsync<MDtoRequestFindByString, TeamFindDtoResponse>(relativePath, request);
    }

    public Task<TeamFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(ITeamActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, TeamFindRangeDtoResponse>(relativePath, request);
    }

    public Task<TeamInsertDtoResponse> CreateAsync(TeamInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ITeamActionName.CreateOne));
        return PostAsync<TeamInsertDtoRequest, TeamInsertDtoResponse>(relativePath, request);
    }

    public Task<TeamInsertRangeDtoResponse> CreateRangeAsync(TeamInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ITeamActionName.CreateRange));
        return PostAsync<TeamInsertRangeDtoRequest, TeamInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<TeamUpdateDtoResponse> UpdateAsync(TeamUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ITeamActionName.UpdateOne));
        return PutAsync<TeamUpdateDtoRequest, TeamUpdateDtoResponse>(relativePath, request);
    }

    public Task<TeamUpdateRangeDtoResponse> UpdateRangeAsync(TeamUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ITeamActionName.UpdateRange));
        return PutAsync<TeamUpdateRangeDtoRequest, TeamUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<TeamDeleteDtoResponse> DeleteAsync(TeamDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ITeamActionName.DeleteOne));
        return DeleteAsync<TeamDeleteDtoRequest, TeamDeleteDtoResponse>(relativePath, request);
    }

    public Task<TeamDeleteRangeDtoResponse> DeleteRangeAsync(TeamDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ITeamActionName.DeleteRange));
        return DeleteAsync<TeamDeleteRangeDtoRequest, TeamDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<TeamSaveRangeDtoResponse> SaveRangeAsync(TeamSaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ITeamActionName.SaveRange));
        return PostAsync<TeamSaveRangeDtoRequest, TeamSaveRangeDtoResponse>(relativePath, request);
    }
}