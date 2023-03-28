using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.DSH.DealStepHistory.Api.Cfg.Routes;
using VSoft.Company.DSH.DealStepHistory.Business.Dto.Request;
using VSoft.Company.DSH.DealStepHistory.Business.Dto.Response;
using VSoft.Company.DSH.DealStepHistory.Client.Models;
using VSoft.Company.DSH.DealStepHistory.Client.Services;

namespace VSoft.Company.DSH.DealStepHistory.Client.Provider.Services;

public class DealStepHistoryClient : ApiDtoClientJSon<IDealStepHistoryClient, MDealStepHistoryClient>, IDealStepHistoryClient
{
    public DealStepHistoryClient(IConfigurationRoot configuration, MDealStepHistoryClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(IDealStepHistoryControllerPath.DealStepHistory);

    public Task<DealStepHistoryFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealStepHistoryActionName.FindOne));
        return GetAsync<MDtoRequestFindByString, DealStepHistoryFindDtoResponse>(relativePath, request);
    }

    public Task<DealStepHistoryFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealStepHistoryActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, DealStepHistoryFindRangeDtoResponse>(relativePath, request);
    }

    public Task<DealStepHistoryInsertDtoResponse> CreateAsync(DealStepHistoryInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealStepHistoryActionName.CreateOne));
        return PostAsync<DealStepHistoryInsertDtoRequest, DealStepHistoryInsertDtoResponse>(relativePath, request);
    }

    public Task<DealStepHistoryInsertRangeDtoResponse> CreateRangeAsync(DealStepHistoryInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealStepHistoryActionName.CreateRange));
        return PostAsync<DealStepHistoryInsertRangeDtoRequest, DealStepHistoryInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<DealStepHistoryUpdateDtoResponse> UpdateAsync(DealStepHistoryUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealStepHistoryActionName.UpdateOne));
        return PutAsync<DealStepHistoryUpdateDtoRequest, DealStepHistoryUpdateDtoResponse>(relativePath, request);
    }

    public Task<DealStepHistoryUpdateRangeDtoResponse> UpdateRangeAsync(DealStepHistoryUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealStepHistoryActionName.UpdateRange));
        return PutAsync<DealStepHistoryUpdateRangeDtoRequest, DealStepHistoryUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<DealStepHistoryDeleteDtoResponse> DeleteAsync(DealStepHistoryDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealStepHistoryActionName.DeleteOne));
        return DeleteAsync<DealStepHistoryDeleteDtoRequest, DealStepHistoryDeleteDtoResponse>(relativePath, request);
    }

    public Task<DealStepHistoryDeleteRangeDtoResponse> DeleteRangeAsync(DealStepHistoryDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealStepHistoryActionName.DeleteRange));
        return DeleteAsync<DealStepHistoryDeleteRangeDtoRequest, DealStepHistoryDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<DealStepHistorySaveRangeDtoResponse> SaveRangeAsync(DealStepHistorySaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealStepHistoryActionName.SaveRange));
        return PostAsync<DealStepHistorySaveRangeDtoRequest, DealStepHistorySaveRangeDtoResponse>(relativePath, request);
    }
}