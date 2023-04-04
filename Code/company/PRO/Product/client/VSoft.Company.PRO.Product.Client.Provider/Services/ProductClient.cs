using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.PRO.Product.Api.Cfg.Routes;
using VSoft.Company.PRO.Product.Business.Dto.Request;
using VSoft.Company.PRO.Product.Business.Dto.Response;
using VSoft.Company.PRO.Product.Client.Models;
using VSoft.Company.PRO.Product.Client.Services;

namespace VSoft.Company.PRO.Product.Client.Provider.Services;

public class ProductClient : ApiDtoClientJSon<IProductClient, MProductClient>, IProductClient
{
    public ProductClient(IConfigurationRoot configuration, MProductClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(IProductControllerPath.Product);

    public Task<ProductFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductActionName.FindOne));
        return GetAsync<MDtoRequestFindByString, ProductFindDtoResponse>(relativePath, request);
    }

    public Task<ProductFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, ProductFindRangeDtoResponse>(relativePath, request);
    }

    public Task<ProductInsertDtoResponse> CreateAsync(ProductInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductActionName.CreateOne));
        return PostAsync<ProductInsertDtoRequest, ProductInsertDtoResponse>(relativePath, request);
    }

    public Task<ProductInsertRangeDtoResponse> CreateRangeAsync(ProductInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductActionName.CreateRange));
        return PostAsync<ProductInsertRangeDtoRequest, ProductInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<ProductUpdateDtoResponse> UpdateAsync(ProductUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductActionName.UpdateOne));
        return PutAsync<ProductUpdateDtoRequest, ProductUpdateDtoResponse>(relativePath, request);
    }

    public Task<ProductUpdateRangeDtoResponse> UpdateRangeAsync(ProductUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductActionName.UpdateRange));
        return PutAsync<ProductUpdateRangeDtoRequest, ProductUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<ProductDeleteDtoResponse> DeleteAsync(ProductDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductActionName.DeleteOne));
        return DeleteAsync<ProductDeleteDtoRequest, ProductDeleteDtoResponse>(relativePath, request);
    }

    public Task<ProductDeleteRangeDtoResponse> DeleteRangeAsync(ProductDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductActionName.DeleteRange));
        return DeleteAsync<ProductDeleteRangeDtoRequest, ProductDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<ProductSaveRangeDtoResponse> SaveRangeAsync(ProductSaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductActionName.SaveRange));
        return PostAsync<ProductSaveRangeDtoRequest, ProductSaveRangeDtoResponse>(relativePath, request);
    }
    public Task<ProductTableKeySearchDtoResponse> GetTableByKeyword(ProductTableKeySearchDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductActionName.FindTable));
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
        return GetQueryAsync<ProductTableKeySearchDtoResponse>(relativePath, query);
    }
}