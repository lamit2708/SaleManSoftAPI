using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.POR.ProductOrder.Api.Cfg.Routes;
using VSoft.Company.POR.ProductOrder.Business.Dto.Request;
using VSoft.Company.POR.ProductOrder.Business.Dto.Response;
using VSoft.Company.POR.ProductOrder.Client.Models;
using VSoft.Company.POR.ProductOrder.Client.Services;

namespace VSoft.Company.POR.ProductOrder.Client.Provider.Services;

public class ProductOrderClient : ApiDtoClientJSon<IProductOrderClient, MProductOrderClient>, IProductOrderClient
{
    public ProductOrderClient(IConfigurationRoot configuration, MProductOrderClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(IProductOrderControllerPath.ProductOrder);

    public Task<ProductOrderFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductOrderActionName.FindOne));
        return GetAsync<MDtoRequestFindByString, ProductOrderFindDtoResponse>(relativePath, request);
    }

    public Task<ProductOrderFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductOrderActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, ProductOrderFindRangeDtoResponse>(relativePath, request);
    }

    public Task<ProductOrderInsertDtoResponse> CreateAsync(ProductOrderInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductOrderActionName.CreateOne));
        return PostAsync<ProductOrderInsertDtoRequest, ProductOrderInsertDtoResponse>(relativePath, request);
    }

    public Task<ProductOrderInsertRangeDtoResponse> CreateRangeAsync(ProductOrderInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductOrderActionName.CreateRange));
        return PostAsync<ProductOrderInsertRangeDtoRequest, ProductOrderInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<ProductOrderUpdateDtoResponse> UpdateAsync(ProductOrderUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductOrderActionName.UpdateOne));
        return PutAsync<ProductOrderUpdateDtoRequest, ProductOrderUpdateDtoResponse>(relativePath, request);
    }

    public Task<ProductOrderUpdateRangeDtoResponse> UpdateRangeAsync(ProductOrderUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductOrderActionName.UpdateRange));
        return PutAsync<ProductOrderUpdateRangeDtoRequest, ProductOrderUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<ProductOrderDeleteDtoResponse> DeleteAsync(ProductOrderDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductOrderActionName.DeleteOne));
        return DeleteAsync<ProductOrderDeleteDtoRequest, ProductOrderDeleteDtoResponse>(relativePath, request);
    }

    public Task<ProductOrderDeleteRangeDtoResponse> DeleteRangeAsync(ProductOrderDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductOrderActionName.DeleteRange));
        return DeleteAsync<ProductOrderDeleteRangeDtoRequest, ProductOrderDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<ProductOrderSaveRangeDtoResponse> SaveRangeAsync(ProductOrderSaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductOrderActionName.SaveRange));
        return PostAsync<ProductOrderSaveRangeDtoRequest, ProductOrderSaveRangeDtoResponse>(relativePath, request);
    }
}