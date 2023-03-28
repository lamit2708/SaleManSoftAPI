using VegunSoft.Framework.Api.DtoClient.Services;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.QUE.Question.Business.Dto.Request;
using VSoft.Company.QUE.Question.Business.Dto.Response;

namespace VSoft.Company.QUE.Question.Client.Services;

public interface IQuestionClient: IApiDtoClientJSon<IQuestionClient>
{  

    Task<QuestionFindDtoResponse> FindAsync(MDtoRequestFindByString request);

    Task<QuestionFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request);

    Task<QuestionInsertDtoResponse> CreateAsync(QuestionInsertDtoRequest request);

    Task<QuestionInsertRangeDtoResponse> CreateRangeAsync(QuestionInsertRangeDtoRequest request);

    Task<QuestionUpdateDtoResponse> UpdateAsync(QuestionUpdateDtoRequest request);

    Task<QuestionUpdateRangeDtoResponse> UpdateRangeAsync(QuestionUpdateRangeDtoRequest request);

    Task<QuestionDeleteDtoResponse> DeleteAsync(QuestionDeleteDtoRequest request);

    Task<QuestionDeleteRangeDtoResponse> DeleteRangeAsync(QuestionDeleteRangeDtoRequest request);

    Task<QuestionSaveRangeDtoResponse> SaveRangeAsync(QuestionSaveRangeDtoRequest request);
   
}