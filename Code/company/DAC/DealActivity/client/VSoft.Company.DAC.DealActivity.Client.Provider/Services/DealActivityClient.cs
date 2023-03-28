using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.DAC.DealActivity.Api.Cfg.Routes;
using VSoft.Company.DAC.DealActivity.Business.Dto.Request;
using VSoft.Company.DAC.DealActivity.Business.Dto.Response;
using VSoft.Company.DAC.DealActivity.Client.Models;
using VSoft.Company.DAC.DealActivity.Client.Services;

namespace VSoft.Company.DAC.DealActivity.Client.Provider.Services;

public class DealActivityClient : ApiDtoClientJSon<IDealActivityClient, MDealActivityClient>, IDealActivityClient
{
    public DealActivityClient(IConfigurationRoot configuration, MDealActivityClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(IDealActivityControllerPath.DealActivity);

    public Task<DealActivityFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealActivityActionName.FindOne));
        return GetAsync<MDtoRequestFindByString, DealActivityFindDtoResponse>(relativePath, request);
    }

    public Task<DealActivityFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealActivityActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, DealActivityFindRangeDtoResponse>(relativePath, request);
    }

    public Task<DealActivityInsertDtoResponse> CreateAsync(DealActivityInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealActivityActionName.CreateOne));
        return PostAsync<DealActivityInsertDtoRequest, DealActivityInsertDtoResponse>(relativePath, request);
    }

    public Task<DealActivityInsertRangeDtoResponse> CreateRangeAsync(DealActivityInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealActivityActionName.CreateRange));
        return PostAsync<DealActivityInsertRangeDtoRequest, DealActivityInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<DealActivityUpdateDtoResponse> UpdateAsync(DealActivityUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealActivityActionName.UpdateOne));
        return PutAsync<DealActivityUpdateDtoRequest, DealActivityUpdateDtoResponse>(relativePath, request);
    }

    public Task<DealActivityUpdateRangeDtoResponse> UpdateRangeAsync(DealActivityUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealActivityActionName.UpdateRange));
        return PutAsync<DealActivityUpdateRangeDtoRequest, DealActivityUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<DealActivityDeleteDtoResponse> DeleteAsync(DealActivityDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealActivityActionName.DeleteOne));
        return DeleteAsync<DealActivityDeleteDtoRequest, DealActivityDeleteDtoResponse>(relativePath, request);
    }

    public Task<DealActivityDeleteRangeDtoResponse> DeleteRangeAsync(DealActivityDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealActivityActionName.DeleteRange));
        return DeleteAsync<DealActivityDeleteRangeDtoRequest, DealActivityDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<DealActivitySaveRangeDtoResponse> SaveRangeAsync(DealActivitySaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealActivityActionName.SaveRange));
        return PostAsync<DealActivitySaveRangeDtoRequest, DealActivitySaveRangeDtoResponse>(relativePath, request);
    }
}