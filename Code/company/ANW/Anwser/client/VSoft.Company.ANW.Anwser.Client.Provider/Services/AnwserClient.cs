using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.ANW.Anwser.Api.Cfg.Routes;
using VSoft.Company.ANW.Anwser.Business.Dto.Request;
using VSoft.Company.ANW.Anwser.Business.Dto.Response;
using VSoft.Company.ANW.Anwser.Client.Models;
using VSoft.Company.ANW.Anwser.Client.Services;

namespace VSoft.Company.ANW.Anwser.Client.Provider.Services;

public class AnwserClient : ApiDtoClientJSon<IAnwserClient, MAnwserClient>, IAnwserClient
{
    public AnwserClient(IConfigurationRoot configuration, MAnwserClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(IAnwserControllerPath.Anwser);

    public Task<AnwserFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(IAnwserActionName.FindOne));
        return GetAsync<MDtoRequestFindByString, AnwserFindDtoResponse>(relativePath, request);
    }

    public Task<AnwserFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(IAnwserActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, AnwserFindRangeDtoResponse>(relativePath, request);
    }

    public Task<AnwserInsertDtoResponse> CreateAsync(AnwserInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IAnwserActionName.CreateOne));
        return PostAsync<AnwserInsertDtoRequest, AnwserInsertDtoResponse>(relativePath, request);
    }

    public Task<AnwserInsertRangeDtoResponse> CreateRangeAsync(AnwserInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IAnwserActionName.CreateRange));
        return PostAsync<AnwserInsertRangeDtoRequest, AnwserInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<AnwserUpdateDtoResponse> UpdateAsync(AnwserUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IAnwserActionName.UpdateOne));
        return PutAsync<AnwserUpdateDtoRequest, AnwserUpdateDtoResponse>(relativePath, request);
    }

    public Task<AnwserUpdateRangeDtoResponse> UpdateRangeAsync(AnwserUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IAnwserActionName.UpdateRange));
        return PutAsync<AnwserUpdateRangeDtoRequest, AnwserUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<AnwserDeleteDtoResponse> DeleteAsync(AnwserDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IAnwserActionName.DeleteOne));
        return DeleteAsync<AnwserDeleteDtoRequest, AnwserDeleteDtoResponse>(relativePath, request);
    }

    public Task<AnwserDeleteRangeDtoResponse> DeleteRangeAsync(AnwserDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IAnwserActionName.DeleteRange));
        return DeleteAsync<AnwserDeleteRangeDtoRequest, AnwserDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<AnwserSaveRangeDtoResponse> SaveRangeAsync(AnwserSaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IAnwserActionName.SaveRange));
        return PostAsync<AnwserSaveRangeDtoRequest, AnwserSaveRangeDtoResponse>(relativePath, request);
    }
}