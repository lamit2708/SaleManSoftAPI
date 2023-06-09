﻿using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.PRC.ProductCategory.Api.Cfg.Routes;
using VSoft.Company.PRC.ProductCategory.Business.Dto.Request;
using VSoft.Company.PRC.ProductCategory.Business.Dto.Response;
using VSoft.Company.PRC.ProductCategory.Client.Models;
using VSoft.Company.PRC.ProductCategory.Client.Services;

namespace VSoft.Company.PRC.ProductCategory.Client.Provider.Services;

public class ProductCategoryClient : ApiDtoClientJSon<IProductCategoryClient, MProductCategoryClient>, IProductCategoryClient
{
    public ProductCategoryClient(IConfigurationRoot configuration, MProductCategoryClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(IProductCategoryControllerPath.ProductCategory);

    public Task<ProductCategoryFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductCategoryActionName.FindOne));
        var query = new Dictionary<string, string>()
        {
            [nameof(request.Id)] = request.Id?.ToString() ?? string.Empty,
        };
        return GetQueryAsync<ProductCategoryFindDtoResponse>(relativePath, query);
    }

    public Task<ProductCategoryFindRangeDtoResponse> GetAll()
    {
        var relativePath = Controller.GetApiPath(nameof(IProductCategoryActionName.GetAll));
        return GetQueryAsync<ProductCategoryFindRangeDtoResponse>(relativePath, null);
    }

    public Task<ProductCategoryTableKeySearchDtoResponse> GetTableByKeyword(ProductCategoryTableKeySearchDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductCategoryActionName.FindTable));
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
        return GetQueryAsync<ProductCategoryTableKeySearchDtoResponse>(relativePath, query);
    }

    public Task<ProductCategoryFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductCategoryActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, ProductCategoryFindRangeDtoResponse>(relativePath, request);
    }

    public Task<ProductCategoryInsertDtoResponse> CreateAsync(ProductCategoryInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductCategoryActionName.CreateOne));
        return PostAsync<ProductCategoryInsertDtoRequest, ProductCategoryInsertDtoResponse>(relativePath, request);
    }

    public Task<ProductCategoryInsertRangeDtoResponse> CreateRangeAsync(ProductCategoryInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductCategoryActionName.CreateRange));
        return PostAsync<ProductCategoryInsertRangeDtoRequest, ProductCategoryInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<ProductCategoryUpdateDtoResponse> UpdateAsync(ProductCategoryUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductCategoryActionName.UpdateOne));
        return PutAsync<ProductCategoryUpdateDtoRequest, ProductCategoryUpdateDtoResponse>(relativePath, request);
    }

    public Task<ProductCategoryUpdateRangeDtoResponse> UpdateRangeAsync(ProductCategoryUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductCategoryActionName.UpdateRange));
        return PutAsync<ProductCategoryUpdateRangeDtoRequest, ProductCategoryUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<ProductCategoryDeleteDtoResponse> DeleteAsync(ProductCategoryDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductCategoryActionName.DeleteOne));
        return DeleteAsync<ProductCategoryDeleteDtoRequest, ProductCategoryDeleteDtoResponse>(relativePath, request);
    }

    public Task<ProductCategoryDeleteRangeDtoResponse> DeleteRangeAsync(ProductCategoryDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductCategoryActionName.DeleteRange));
        return DeleteAsync<ProductCategoryDeleteRangeDtoRequest, ProductCategoryDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<ProductCategorySaveRangeDtoResponse> SaveRangeAsync(ProductCategorySaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductCategoryActionName.SaveRange));
        return PostAsync<ProductCategorySaveRangeDtoRequest, ProductCategorySaveRangeDtoResponse>(relativePath, request);
    }
}