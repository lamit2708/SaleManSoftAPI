using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VegunSoft.Framework.Paging.Provider.Request;
using VegunSoft.Framework.Paging.Provider.Response;
using VSoft.Company.PRF.ProductFeature.Api.Cfg.Routes;
using VSoft.Company.PRF.ProductFeature.Business.Dto.Request;
using VSoft.Company.PRF.ProductFeature.Business.Dto.Response;
//using VSoft.Company.PRF.ProductFeature.Api.Cfg.Routes;
//using VSoft.Company.PRF.ProductFeature.Business.Dto.Data;
//using VSoft.Company.PRF.ProductFeature.Business.Dto.Request;
//using VSoft.Company.PRF.ProductFeature.Business.Dto.Response;
using VSoft.Company.PRF.ProductFeature.Client.Models;
using VSoft.Company.PRF.ProductFeature.Client.Services;

namespace VSoft.Company.PRF.ProductFeature.Client.Provider.Services;

public class ProductFeatureClient : ApiDtoClientJSon<IProductFeatureClient, MProductFeatureClient>, IProductFeatureClient
{
    public ProductFeatureClient(IConfigurationRoot configuration, MProductFeatureClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
        //  BaseAddress = "https://localhost:7174/";
        //  Client.BaseAddress = new Uri(BaseAddress);
    }

    public override string Controller { get; } = nameof(IProductFeatureControllerPath.ProductFeature);

    public Task<ProductFeatureTableKeySearchDtoResponse> GetTableByKeyword(ProductFeatureTableKeySearchDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductFeatureActionName.FindTable));
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
        return GetQueryAsync<ProductFeatureTableKeySearchDtoResponse>(relativePath, query);
    }

    public Task<ProductFeatureFindDtoResponse> FindAsync(MDtoRequestFindByInt request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductFeatureActionName.FindOne));
        var query = new Dictionary<string, string>()
        {
            [nameof(request.Id)] = request.Id.ToString(),
        };
        return GetQueryAsync<ProductFeatureFindDtoResponse>(relativePath, query);
    }

    public Task<ProductFeatureFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductFeatureActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, ProductFeatureFindRangeDtoResponse>(relativePath, request);
    }

    public Task<ProductFeatureInsertDtoResponse> CreateAsync(ProductFeatureInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductFeatureActionName.CreateOne));
        return PostAsync<ProductFeatureInsertDtoRequest, ProductFeatureInsertDtoResponse>(relativePath, request);
    }

    public Task<ProductFeatureInsertRangeDtoResponse> CreateRangeAsync(ProductFeatureInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductFeatureActionName.CreateRange));
        return PostAsync<ProductFeatureInsertRangeDtoRequest, ProductFeatureInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<ProductFeatureUpdateDtoResponse> UpdateAsync(ProductFeatureUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductFeatureActionName.UpdateOne));
        return PutAsync<ProductFeatureUpdateDtoRequest, ProductFeatureUpdateDtoResponse>(relativePath, request);
    }

    public Task<ProductFeatureUpdateRangeDtoResponse> UpdateRangeAsync(ProductFeatureUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductFeatureActionName.UpdateRange));
        return PutAsync<ProductFeatureUpdateRangeDtoRequest, ProductFeatureUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<ProductFeatureDeleteDtoResponse> DeleteAsync(ProductFeatureDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductFeatureActionName.DeleteOne));
        return DeleteAsync<ProductFeatureDeleteDtoRequest, ProductFeatureDeleteDtoResponse>(relativePath, request);
    }

    public Task<ProductFeatureDeleteRangeDtoResponse> DeleteRangeAsync(ProductFeatureDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductFeatureActionName.DeleteRange));
        return DeleteAsync<ProductFeatureDeleteRangeDtoRequest, ProductFeatureDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<ProductFeatureSaveRangeDtoResponse> SaveRangeAsync(ProductFeatureSaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IProductFeatureActionName.SaveRange));
        return PostAsync<ProductFeatureSaveRangeDtoRequest, ProductFeatureSaveRangeDtoResponse>(relativePath, request);
    }

    public Task<ProductFeatureKeyValueResponse> GetAllKeyValue()
    {
        var relativePath = Controller.GetApiPath(nameof(IProductFeatureActionName.GetAll));
        return GetQueryAsync<ProductFeatureKeyValueResponse>(relativePath, null);
    }
    public Task<ProductFeatureFindRangeDtoResponse> GetAll()
    {
        var relativePath = Controller.GetApiPath(nameof(IProductFeatureActionName.GetAll));
        return GetQueryAsync<ProductFeatureFindRangeDtoResponse>(relativePath, null);
    }
}