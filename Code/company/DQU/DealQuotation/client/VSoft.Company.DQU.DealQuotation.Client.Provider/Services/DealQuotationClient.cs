using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.DQU.DealQuotation.Api.Cfg.Routes;
using VSoft.Company.DQU.DealQuotation.Business.Dto.Request;
using VSoft.Company.DQU.DealQuotation.Business.Dto.Response;
using VSoft.Company.DQU.DealQuotation.Client.Models;
using VSoft.Company.DQU.DealQuotation.Client.Services;

namespace VSoft.Company.DQU.DealQuotation.Client.Provider.Services;

public class DealQuotationClient : ApiDtoClientJSon<IDealQuotationClient, MDealQuotationClient>, IDealQuotationClient
{
    public DealQuotationClient(IConfigurationRoot configuration, MDealQuotationClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(IDealQuotationControllerPath.DealQuotation);

    public Task<DealQuotationFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealQuotationActionName.FindOne));
        return GetAsync<MDtoRequestFindByString, DealQuotationFindDtoResponse>(relativePath, request);
    }

    public Task<DealQuotationFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealQuotationActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, DealQuotationFindRangeDtoResponse>(relativePath, request);
    }

    public Task<DealQuotationInsertDtoResponse> CreateAsync(DealQuotationInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealQuotationActionName.CreateOne));
        return PostAsync<DealQuotationInsertDtoRequest, DealQuotationInsertDtoResponse>(relativePath, request);
    }

    public Task<DealQuotationInsertRangeDtoResponse> CreateRangeAsync(DealQuotationInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealQuotationActionName.CreateRange));
        return PostAsync<DealQuotationInsertRangeDtoRequest, DealQuotationInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<DealQuotationUpdateDtoResponse> UpdateAsync(DealQuotationUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealQuotationActionName.UpdateOne));
        return PutAsync<DealQuotationUpdateDtoRequest, DealQuotationUpdateDtoResponse>(relativePath, request);
    }

    public Task<DealQuotationUpdateRangeDtoResponse> UpdateRangeAsync(DealQuotationUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealQuotationActionName.UpdateRange));
        return PutAsync<DealQuotationUpdateRangeDtoRequest, DealQuotationUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<DealQuotationDeleteDtoResponse> DeleteAsync(DealQuotationDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealQuotationActionName.DeleteOne));
        return DeleteAsync<DealQuotationDeleteDtoRequest, DealQuotationDeleteDtoResponse>(relativePath, request);
    }

    public Task<DealQuotationDeleteRangeDtoResponse> DeleteRangeAsync(DealQuotationDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealQuotationActionName.DeleteRange));
        return DeleteAsync<DealQuotationDeleteRangeDtoRequest, DealQuotationDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<DealQuotationSaveRangeDtoResponse> SaveRangeAsync(DealQuotationSaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IDealQuotationActionName.SaveRange));
        return PostAsync<DealQuotationSaveRangeDtoRequest, DealQuotationSaveRangeDtoResponse>(relativePath, request);
    }
}