using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.QUE.Question.Api.Cfg.Routes;
using VSoft.Company.QUE.Question.Business.Dto.Request;
using VSoft.Company.QUE.Question.Business.Dto.Response;
using VSoft.Company.QUE.Question.Client.Models;
using VSoft.Company.QUE.Question.Client.Services;

namespace VSoft.Company.QUE.Question.Client.Provider.Services;

public class QuestionClient : ApiDtoClientJSon<IQuestionClient, MQuestionClient>, IQuestionClient
{
    public QuestionClient(IConfigurationRoot configuration, MQuestionClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(IQuestionControllerPath.Question);

    public Task<QuestionFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(IQuestionActionName.FindOne));
        return GetAsync<MDtoRequestFindByString, QuestionFindDtoResponse>(relativePath, request);
    }

    public Task<QuestionFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(IQuestionActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, QuestionFindRangeDtoResponse>(relativePath, request);
    }

    public Task<QuestionInsertDtoResponse> CreateAsync(QuestionInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IQuestionActionName.CreateOne));
        return PostAsync<QuestionInsertDtoRequest, QuestionInsertDtoResponse>(relativePath, request);
    }

    public Task<QuestionInsertRangeDtoResponse> CreateRangeAsync(QuestionInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IQuestionActionName.CreateRange));
        return PostAsync<QuestionInsertRangeDtoRequest, QuestionInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<QuestionUpdateDtoResponse> UpdateAsync(QuestionUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IQuestionActionName.UpdateOne));
        return PutAsync<QuestionUpdateDtoRequest, QuestionUpdateDtoResponse>(relativePath, request);
    }

    public Task<QuestionUpdateRangeDtoResponse> UpdateRangeAsync(QuestionUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IQuestionActionName.UpdateRange));
        return PutAsync<QuestionUpdateRangeDtoRequest, QuestionUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<QuestionDeleteDtoResponse> DeleteAsync(QuestionDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IQuestionActionName.DeleteOne));
        return DeleteAsync<QuestionDeleteDtoRequest, QuestionDeleteDtoResponse>(relativePath, request);
    }

    public Task<QuestionDeleteRangeDtoResponse> DeleteRangeAsync(QuestionDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IQuestionActionName.DeleteRange));
        return DeleteAsync<QuestionDeleteRangeDtoRequest, QuestionDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<QuestionSaveRangeDtoResponse> SaveRangeAsync(QuestionSaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IQuestionActionName.SaveRange));
        return PostAsync<QuestionSaveRangeDtoRequest, QuestionSaveRangeDtoResponse>(relativePath, request);
    }
}