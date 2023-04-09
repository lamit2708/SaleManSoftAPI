using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.DEA.Deal.Api.Cfg.Routes;
using VSoft.Company.DEA.Deal.Business.Dto.Request;
using VSoft.Company.DEA.Deal.Business.Dto.Response;
using VSoft.Company.DEA.Deal.Client.Models;
using VSoft.Company.DEA.Deal.Client.Services;

namespace VSoft.Company.DEA.Deal.Client.Provider.Services;

public class DealClient : ApiDtoClientJSon<IDealClient, MDealClient>, IDealClient
{
    public DealClient(IConfigurationRoot configuration, MDealClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(IDealControllerPath.Deal);

    public Task<DealTableKeySearchDtoResponse> GetTableByKeyword(DealTableKeySearchDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealActionName.FindTable));
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
        return GetQueryAsync<DealTableKeySearchDtoResponse>(relativePath, query);
    }

    public Task<DealFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealActionName.FindOne));
        var query = new Dictionary<string, string>()
        {
            [nameof(request.Id)] = request.Id.ToString(),
        };
        return GetQueryAsync<DealFindDtoResponse>(relativePath, query);
        //return GetAsync<MDtoRequestFindByString, DealFindDtoResponse>(relativePath, request);
    }

    public Task<DealFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, DealFindRangeDtoResponse>(relativePath, request);
    }

    public Task<DealInsertDtoResponse> CreateAsync(DealInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealActionName.CreateOne));
        return PostAsync<DealInsertDtoRequest, DealInsertDtoResponse>(relativePath, request);
    }

    public Task<DealInsertRangeDtoResponse> CreateRangeAsync(DealInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealActionName.CreateRange));
        return PostAsync<DealInsertRangeDtoRequest, DealInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<DealUpdateDtoResponse> UpdateAsync(DealUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealActionName.UpdateOne));
        return PutAsync<DealUpdateDtoRequest, DealUpdateDtoResponse>(relativePath, request);
    }

    public Task<DealUpdateRangeDtoResponse> UpdateRangeAsync(DealUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealActionName.UpdateRange));
        return PutAsync<DealUpdateRangeDtoRequest, DealUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<DealDeleteDtoResponse> DeleteAsync(DealDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealActionName.DeleteOne));
        return DeleteAsync<DealDeleteDtoRequest, DealDeleteDtoResponse>(relativePath, request);
    }

    public Task<DealDeleteRangeDtoResponse> DeleteRangeAsync(DealDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealActionName.DeleteRange));
        return DeleteAsync<DealDeleteRangeDtoRequest, DealDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<DealSaveRangeDtoResponse> SaveRangeAsync(DealSaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealActionName.SaveRange));
        return PostAsync<DealSaveRangeDtoRequest, DealSaveRangeDtoResponse>(relativePath, request);
    }
}