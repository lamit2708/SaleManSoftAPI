using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.VDT.VDealTag.Api.Cfg.Routes;
using VSoft.Company.VDT.VDealTag.Business.Dto.Request;
using VSoft.Company.VDT.VDealTag.Business.Dto.Response;
using VSoft.Company.VDT.VDealTag.Client.Models;
using VSoft.Company.VDT.VDealTag.Client.Services;

namespace VSoft.Company.VDT.VDealTag.Client.Provider.Services;

public class VDealTagClient : ApiDtoClientJSon<IVDealTagClient, MVDealTagClient>, IVDealTagClient
{
    public VDealTagClient(IConfigurationRoot configuration, MVDealTagClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(IVDealTagControllerPath.VDealTag);

	public Task<VDealTagFindDtoResponse> FindAsync(MDtoRequestFindByString request)
	{
		var relativePath = Controller.GetApiPath(nameof(IVDealTagActionName.FindOne));
		var query = new Dictionary<string, string>()
		{
			[nameof(request.Id)] = request?.Id??"",
		};
		return GetQueryAsync<VDealTagFindDtoResponse>(relativePath, query);
	}
	public Task<VDealTagFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(IVDealTagActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, VDealTagFindRangeDtoResponse>(relativePath, request);
    }

    public Task<VDealTagTableKeySearchDtoResponse> GetTableByKeyword(VDealTagTableKeySearchDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IVDealTagActionName.FindTable));
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
        return GetQueryAsync<VDealTagTableKeySearchDtoResponse>(relativePath, query);
    }

    public Task<VDealTagFilterDtoResponse> GetByFilter(VDealTagFilterDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IVDealTagActionName.Filter));
        var filterName = nameof(request.Filter);
        var langCodeName = nameof(request.LangCode);
        var langShowExContent = nameof(request.ShowExContent);
        var langShowExMessage = nameof(request.ShowExMessage);
        var query = new Dictionary<string, string>()
        {
            [$"{filterName}.{nameof(request.Filter.Buffer)}"] = "a",
        };
        if (request.LangCode != null)
            query.Add(langCodeName, request.LangCode.ToString());
        if (request.ShowExContent != null)
            query.Add(langShowExContent, request.ShowExContent.ToString());
        if (request.ShowExMessage != null)
            query.Add(langShowExMessage, request.ShowExMessage.ToString());
        if (request.Filter.TeamId != null)
            query.Add($"{filterName}.{nameof(request.Filter.TeamId)}", request.Filter.TeamId.ToString());
        if (request.Filter.UserId != null)
            query.Add($"{filterName}.{nameof(request.Filter.UserId)}", request.Filter.UserId.ToString());
        if (request.Filter.Date != null)
            query.Add($"{filterName}.{nameof(request.Filter.Date)}", request.Filter.Date.ToString());
        if (request.Filter.Keyword != null)
            query.Add($"{filterName}.{nameof(request.Filter.Keyword)}", request.Filter.Keyword.ToString());
        return GetQueryAsync<VDealTagFilterDtoResponse>(relativePath, query);
    }
}