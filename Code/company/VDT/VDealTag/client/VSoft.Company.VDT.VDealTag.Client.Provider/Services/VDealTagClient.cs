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

    //public Task<VDealTagFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    //{
    //    var relativePath = Controller.GetApiPath(nameof(IVDealTagActionName.FindOne));
    //    return GetAsync<MDtoRequestFindByString, VDealTagFindDtoResponse>(relativePath, request);
    //}
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

    public Task<VDealTagInsertDtoResponse> CreateAsync(VDealTagInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IVDealTagActionName.CreateOne));
        return PostAsync<VDealTagInsertDtoRequest, VDealTagInsertDtoResponse>(relativePath, request);
    }

    public Task<VDealTagInsertRangeDtoResponse> CreateRangeAsync(VDealTagInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IVDealTagActionName.CreateRange));
        return PostAsync<VDealTagInsertRangeDtoRequest, VDealTagInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<VDealTagUpdateDtoResponse> UpdateAsync(VDealTagUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IVDealTagActionName.UpdateOne));
        return PutAsync<VDealTagUpdateDtoRequest, VDealTagUpdateDtoResponse>(relativePath, request);
    }

    public Task<VDealTagUpdateRangeDtoResponse> UpdateRangeAsync(VDealTagUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IVDealTagActionName.UpdateRange));
        return PutAsync<VDealTagUpdateRangeDtoRequest, VDealTagUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<VDealTagDeleteDtoResponse> DeleteAsync(VDealTagDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IVDealTagActionName.DeleteOne));
        return DeleteAsync<VDealTagDeleteDtoRequest, VDealTagDeleteDtoResponse>(relativePath, request);
    }

    public Task<VDealTagDeleteRangeDtoResponse> DeleteRangeAsync(VDealTagDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IVDealTagActionName.DeleteRange));
        return DeleteAsync<VDealTagDeleteRangeDtoRequest, VDealTagDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<VDealTagSaveRangeDtoResponse> SaveRangeAsync(VDealTagSaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IVDealTagActionName.SaveRange));
        return PostAsync<VDealTagSaveRangeDtoRequest, VDealTagSaveRangeDtoResponse>(relativePath, request);
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
}