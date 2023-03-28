using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.PRI.Priority.Api.Cfg.Routes;
using VSoft.Company.PRI.Priority.Business.Dto.Request;
using VSoft.Company.PRI.Priority.Business.Dto.Response;
using VSoft.Company.PRI.Priority.Client.Models;
using VSoft.Company.PRI.Priority.Client.Services;

namespace VSoft.Company.PRI.Priority.Client.Provider.Services;

public class PriorityClient : ApiDtoClientJSon<IPriorityClient, MPriorityClient>, IPriorityClient
{
    public PriorityClient(IConfigurationRoot configuration, MPriorityClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(IPriorityControllerPath.Priority);

    public Task<PriorityFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(IPriorityActionName.FindOne));
        return GetAsync<MDtoRequestFindByString, PriorityFindDtoResponse>(relativePath, request);
    }

    public Task<PriorityFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(IPriorityActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, PriorityFindRangeDtoResponse>(relativePath, request);
    }

    public Task<PriorityInsertDtoResponse> CreateAsync(PriorityInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IPriorityActionName.CreateOne));
        return PostAsync<PriorityInsertDtoRequest, PriorityInsertDtoResponse>(relativePath, request);
    }

    public Task<PriorityInsertRangeDtoResponse> CreateRangeAsync(PriorityInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IPriorityActionName.CreateRange));
        return PostAsync<PriorityInsertRangeDtoRequest, PriorityInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<PriorityUpdateDtoResponse> UpdateAsync(PriorityUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IPriorityActionName.UpdateOne));
        return PutAsync<PriorityUpdateDtoRequest, PriorityUpdateDtoResponse>(relativePath, request);
    }

    public Task<PriorityUpdateRangeDtoResponse> UpdateRangeAsync(PriorityUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IPriorityActionName.UpdateRange));
        return PutAsync<PriorityUpdateRangeDtoRequest, PriorityUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<PriorityDeleteDtoResponse> DeleteAsync(PriorityDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IPriorityActionName.DeleteOne));
        return DeleteAsync<PriorityDeleteDtoRequest, PriorityDeleteDtoResponse>(relativePath, request);
    }

    public Task<PriorityDeleteRangeDtoResponse> DeleteRangeAsync(PriorityDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IPriorityActionName.DeleteRange));
        return DeleteAsync<PriorityDeleteRangeDtoRequest, PriorityDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<PrioritySaveRangeDtoResponse> SaveRangeAsync(PrioritySaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IPriorityActionName.SaveRange));
        return PostAsync<PrioritySaveRangeDtoRequest, PrioritySaveRangeDtoResponse>(relativePath, request);
    }
}