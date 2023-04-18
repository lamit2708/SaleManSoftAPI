using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.DST.DealStep.Api.Cfg.Routes;
using VSoft.Company.DST.DealStep.Business.Dto.Request;
using VSoft.Company.DST.DealStep.Business.Dto.Response;
using VSoft.Company.DST.DealStep.Client.Models;
using VSoft.Company.DST.DealStep.Client.Services;

namespace VSoft.Company.DST.DealStep.Client.Provider.Services;

public class DealStepClient : ApiDtoClientJSon<IDealStepClient, MDealStepClient>, IDealStepClient
{
    public DealStepClient(IConfigurationRoot configuration, MDealStepClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(IDealStepControllerPath.DealStep);

    public Task<DealStepFindRangeDtoResponse> GetAll()
    {
        var relativePath = Controller.GetApiPath(nameof(IDealStepActionName.GetAll));
        return GetQueryAsync<DealStepFindRangeDtoResponse>(relativePath, null);
    }

    public Task<DealStepFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealStepActionName.FindOne));
        return GetAsync<MDtoRequestFindByString, DealStepFindDtoResponse>(relativePath, request);
    }

    public Task<DealStepFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealStepActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, DealStepFindRangeDtoResponse>(relativePath, request);
    }

    public Task<DealStepInsertDtoResponse> CreateAsync(DealStepInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealStepActionName.CreateOne));
        return PostAsync<DealStepInsertDtoRequest, DealStepInsertDtoResponse>(relativePath, request);
    }

    public Task<DealStepInsertRangeDtoResponse> CreateRangeAsync(DealStepInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealStepActionName.CreateRange));
        return PostAsync<DealStepInsertRangeDtoRequest, DealStepInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<DealStepUpdateDtoResponse> UpdateAsync(DealStepUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealStepActionName.UpdateOne));
        return PutAsync<DealStepUpdateDtoRequest, DealStepUpdateDtoResponse>(relativePath, request);
    }

    public Task<DealStepUpdateRangeDtoResponse> UpdateRangeAsync(DealStepUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealStepActionName.UpdateRange));
        return PutAsync<DealStepUpdateRangeDtoRequest, DealStepUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<DealStepDeleteDtoResponse> DeleteAsync(DealStepDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealStepActionName.DeleteOne));
        return DeleteAsync<DealStepDeleteDtoRequest, DealStepDeleteDtoResponse>(relativePath, request);
    }

    public Task<DealStepDeleteRangeDtoResponse> DeleteRangeAsync(DealStepDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealStepActionName.DeleteRange));
        return DeleteAsync<DealStepDeleteRangeDtoRequest, DealStepDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<DealStepSaveRangeDtoResponse> SaveRangeAsync(DealStepSaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealStepActionName.SaveRange));
        return PostAsync<DealStepSaveRangeDtoRequest, DealStepSaveRangeDtoResponse>(relativePath, request);
    }
}