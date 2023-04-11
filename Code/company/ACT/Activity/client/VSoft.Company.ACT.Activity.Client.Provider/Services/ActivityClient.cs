using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.ACT.Activity.Api.Cfg.Routes;
using VSoft.Company.ACT.Activity.Business.Dto.Request;
using VSoft.Company.ACT.Activity.Business.Dto.Response;
using VSoft.Company.ACT.Activity.Client.Models;
using VSoft.Company.ACT.Activity.Client.Services;

namespace VSoft.Company.ACT.Activity.Client.Provider.Services;

public class ActivityClient : ApiDtoClientJSon<IActivityClient, MActivityClient>, IActivityClient
{
    public ActivityClient(IConfigurationRoot configuration, MActivityClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(IActivityControllerPath.Activity);

    public Task<ActivityTableKeySearchDtoResponse> GetTableByKeyword(ActivityTableKeySearchDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IActivityActionName.FindTable));
        var pagingParamName = nameof(request.PagingParams);
        var langCodeName = nameof(request.LangCode);
        var langShowExContent = nameof(request.ShowExContent);
        var langShowExMessage = nameof(request.ShowExMessage);
        var query = new Dictionary<string, string>()
        {
            [$"{pagingParamName}.{nameof(request.PagingParams.PageNumber)}"] = request.PagingParams.PageNumber.ToString(),
            [$"{pagingParamName}.{nameof(request.PagingParams.PageSize)}"] = request.PagingParams.PageSize.ToString(),
        };
        if (request.LangCode != null)
            query.Add(langCodeName, request.LangCode.ToString());
        if (request.ShowExContent != null)
            query.Add(langShowExContent, request.ShowExContent.ToString());
        if (request.ShowExMessage != null)
            query.Add(langShowExMessage, request.ShowExMessage.ToString());
        if (!string.IsNullOrEmpty(request.Data))
            query.Add(nameof(request.Data), request.Data);
        return GetQueryAsync<ActivityTableKeySearchDtoResponse>(relativePath, query);
    }

    public Task<ActivityFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(IActivityActionName.FindOne));
        var query = new Dictionary<string, string>()
        {
            [nameof(request.Id)] = request.Id.ToString(),
        };
        return GetQueryAsync<ActivityFindDtoResponse>(relativePath, query);
    }

    public Task<ActivityFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(IActivityActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, ActivityFindRangeDtoResponse>(relativePath, request);
    }

    public Task<ActivityInsertDtoResponse> CreateAsync(ActivityInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IActivityActionName.CreateOne));
        return PostAsync<ActivityInsertDtoRequest, ActivityInsertDtoResponse>(relativePath, request);
    }

    public Task<ActivityInsertRangeDtoResponse> CreateRangeAsync(ActivityInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IActivityActionName.CreateRange));
        return PostAsync<ActivityInsertRangeDtoRequest, ActivityInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<ActivityUpdateDtoResponse> UpdateAsync(ActivityUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IActivityActionName.UpdateOne));
        return PutAsync<ActivityUpdateDtoRequest, ActivityUpdateDtoResponse>(relativePath, request);
    }

    public Task<ActivityUpdateRangeDtoResponse> UpdateRangeAsync(ActivityUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IActivityActionName.UpdateRange));
        return PutAsync<ActivityUpdateRangeDtoRequest, ActivityUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<ActivityDeleteDtoResponse> DeleteAsync(ActivityDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IActivityActionName.DeleteOne));
        return DeleteAsync<ActivityDeleteDtoRequest, ActivityDeleteDtoResponse>(relativePath, request);
    }

    public Task<ActivityDeleteRangeDtoResponse> DeleteRangeAsync(ActivityDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IActivityActionName.DeleteRange));
        return DeleteAsync<ActivityDeleteRangeDtoRequest, ActivityDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<ActivitySaveRangeDtoResponse> SaveRangeAsync(ActivitySaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IActivityActionName.SaveRange));
        return PostAsync<ActivitySaveRangeDtoRequest, ActivitySaveRangeDtoResponse>(relativePath, request);
    }
}