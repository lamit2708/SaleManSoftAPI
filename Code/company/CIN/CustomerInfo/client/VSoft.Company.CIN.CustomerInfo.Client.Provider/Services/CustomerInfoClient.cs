using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.CIN.CustomerInfo.Api.Cfg.Routes;
using VSoft.Company.CIN.CustomerInfo.Business.Dto.Request;
using VSoft.Company.CIN.CustomerInfo.Business.Dto.Response;
using VSoft.Company.CIN.CustomerInfo.Client.Models;
using VSoft.Company.CIN.CustomerInfo.Client.Services;

namespace VSoft.Company.CIN.CustomerInfo.Client.Provider.Services;

public class CustomerInfoClient : ApiDtoClientJSon<ICustomerInfoClient, MCustomerInfoClient>, ICustomerInfoClient
{
    public CustomerInfoClient(IConfigurationRoot configuration, MCustomerInfoClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(ICustomerInfoControllerPath.CustomerInfo);

    public Task<CustomerInfoFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerInfoActionName.FindOne));
        return GetAsync<MDtoRequestFindByString, CustomerInfoFindDtoResponse>(relativePath, request);
    }

    public Task<CustomerInfoFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerInfoActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, CustomerInfoFindRangeDtoResponse>(relativePath, request);
    }

    public Task<CustomerInfoInsertDtoResponse> CreateAsync(CustomerInfoInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerInfoActionName.CreateOne));
        return PostAsync<CustomerInfoInsertDtoRequest, CustomerInfoInsertDtoResponse>(relativePath, request);
    }

    public Task<CustomerInfoInsertRangeDtoResponse> CreateRangeAsync(CustomerInfoInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerInfoActionName.CreateRange));
        return PostAsync<CustomerInfoInsertRangeDtoRequest, CustomerInfoInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<CustomerInfoUpdateDtoResponse> UpdateAsync(CustomerInfoUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerInfoActionName.UpdateOne));
        return PutAsync<CustomerInfoUpdateDtoRequest, CustomerInfoUpdateDtoResponse>(relativePath, request);
    }

    public Task<CustomerInfoUpdateRangeDtoResponse> UpdateRangeAsync(CustomerInfoUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerInfoActionName.UpdateRange));
        return PutAsync<CustomerInfoUpdateRangeDtoRequest, CustomerInfoUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<CustomerInfoDeleteDtoResponse> DeleteAsync(CustomerInfoDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerInfoActionName.DeleteOne));
        return DeleteAsync<CustomerInfoDeleteDtoRequest, CustomerInfoDeleteDtoResponse>(relativePath, request);
    }

    public Task<CustomerInfoDeleteRangeDtoResponse> DeleteRangeAsync(CustomerInfoDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerInfoActionName.DeleteRange));
        return DeleteAsync<CustomerInfoDeleteRangeDtoRequest, CustomerInfoDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<CustomerInfoSaveRangeDtoResponse> SaveRangeAsync(CustomerInfoSaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerInfoActionName.SaveRange));
        return PostAsync<CustomerInfoSaveRangeDtoRequest, CustomerInfoSaveRangeDtoResponse>(relativePath, request);
    }
}