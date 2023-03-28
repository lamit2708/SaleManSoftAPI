using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.ORD.Order.Api.Cfg.Routes;
using VSoft.Company.ORD.Order.Business.Dto.Request;
using VSoft.Company.ORD.Order.Business.Dto.Response;
using VSoft.Company.ORD.Order.Client.Models;
using VSoft.Company.ORD.Order.Client.Services;

namespace VSoft.Company.ORD.Order.Client.Provider.Services;

public class OrderClient : ApiDtoClientJSon<IOrderClient, MOrderClient>, IOrderClient
{
    public OrderClient(IConfigurationRoot configuration, MOrderClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(IOrderControllerPath.Order);

    public Task<OrderFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(IOrderActionName.FindOne));
        return GetAsync<MDtoRequestFindByString, OrderFindDtoResponse>(relativePath, request);
    }

    public Task<OrderFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(IOrderActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, OrderFindRangeDtoResponse>(relativePath, request);
    }

    public Task<OrderInsertDtoResponse> CreateAsync(OrderInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IOrderActionName.CreateOne));
        return PostAsync<OrderInsertDtoRequest, OrderInsertDtoResponse>(relativePath, request);
    }

    public Task<OrderInsertRangeDtoResponse> CreateRangeAsync(OrderInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IOrderActionName.CreateRange));
        return PostAsync<OrderInsertRangeDtoRequest, OrderInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<OrderUpdateDtoResponse> UpdateAsync(OrderUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IOrderActionName.UpdateOne));
        return PutAsync<OrderUpdateDtoRequest, OrderUpdateDtoResponse>(relativePath, request);
    }

    public Task<OrderUpdateRangeDtoResponse> UpdateRangeAsync(OrderUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IOrderActionName.UpdateRange));
        return PutAsync<OrderUpdateRangeDtoRequest, OrderUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<OrderDeleteDtoResponse> DeleteAsync(OrderDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IOrderActionName.DeleteOne));
        return DeleteAsync<OrderDeleteDtoRequest, OrderDeleteDtoResponse>(relativePath, request);
    }

    public Task<OrderDeleteRangeDtoResponse> DeleteRangeAsync(OrderDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IOrderActionName.DeleteRange));
        return DeleteAsync<OrderDeleteRangeDtoRequest, OrderDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<OrderSaveRangeDtoResponse> SaveRangeAsync(OrderSaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IOrderActionName.SaveRange));
        return PostAsync<OrderSaveRangeDtoRequest, OrderSaveRangeDtoResponse>(relativePath, request);
    }
}