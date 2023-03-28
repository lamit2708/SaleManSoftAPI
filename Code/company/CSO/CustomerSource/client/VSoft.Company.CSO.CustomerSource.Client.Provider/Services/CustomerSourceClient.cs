using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.CSO.CustomerSource.Api.Cfg.Routes;
using VSoft.Company.CSO.CustomerSource.Business.Dto.Request;
using VSoft.Company.CSO.CustomerSource.Business.Dto.Response;
using VSoft.Company.CSO.CustomerSource.Client.Models;
using VSoft.Company.CSO.CustomerSource.Client.Services;

namespace VSoft.Company.CSO.CustomerSource.Client.Provider.Services;

public class CustomerSourceClient : ApiDtoClientJSon<ICustomerSourceClient, MCustomerSourceClient>, ICustomerSourceClient
{
    public CustomerSourceClient(IConfigurationRoot configuration, MCustomerSourceClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(ICustomerSourceControllerPath.CustomerSource);

    public Task<CustomerSourceFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerSourceActionName.FindOne));
        return GetAsync<MDtoRequestFindByString, CustomerSourceFindDtoResponse>(relativePath, request);
    }

    public Task<CustomerSourceFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerSourceActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, CustomerSourceFindRangeDtoResponse>(relativePath, request);
    }

    public Task<CustomerSourceInsertDtoResponse> CreateAsync(CustomerSourceInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerSourceActionName.CreateOne));
        return PostAsync<CustomerSourceInsertDtoRequest, CustomerSourceInsertDtoResponse>(relativePath, request);
    }

    public Task<CustomerSourceInsertRangeDtoResponse> CreateRangeAsync(CustomerSourceInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerSourceActionName.CreateRange));
        return PostAsync<CustomerSourceInsertRangeDtoRequest, CustomerSourceInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<CustomerSourceUpdateDtoResponse> UpdateAsync(CustomerSourceUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerSourceActionName.UpdateOne));
        return PutAsync<CustomerSourceUpdateDtoRequest, CustomerSourceUpdateDtoResponse>(relativePath, request);
    }

    public Task<CustomerSourceUpdateRangeDtoResponse> UpdateRangeAsync(CustomerSourceUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerSourceActionName.UpdateRange));
        return PutAsync<CustomerSourceUpdateRangeDtoRequest, CustomerSourceUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<CustomerSourceDeleteDtoResponse> DeleteAsync(CustomerSourceDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerSourceActionName.DeleteOne));
        return DeleteAsync<CustomerSourceDeleteDtoRequest, CustomerSourceDeleteDtoResponse>(relativePath, request);
    }

    public Task<CustomerSourceDeleteRangeDtoResponse> DeleteRangeAsync(CustomerSourceDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerSourceActionName.DeleteRange));
        return DeleteAsync<CustomerSourceDeleteRangeDtoRequest, CustomerSourceDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<CustomerSourceSaveRangeDtoResponse> SaveRangeAsync(CustomerSourceSaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerSourceActionName.SaveRange));
        return PostAsync<CustomerSourceSaveRangeDtoRequest, CustomerSourceSaveRangeDtoResponse>(relativePath, request);
    }
}