using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.Dto.Response;
using VSoft.Company.QUE.Question.Business.Dto.Request;
using VSoft.Company.QUE.Question.Business.Dto.Response;

namespace VSoft.Company.QUE.Question.Business.Services;

public interface IQuestionMgmtBus
{
    MDtoResponseString GetFullName(MDtoRequestFindByLong request);

    Task<MDtoResponseString> GetFullNameAsync(MDtoRequestFindByLong request);

    QuestionFindDtoResponse Find(MDtoRequestFindByLong request);

    Task<QuestionFindDtoResponse> FindAsync(MDtoRequestFindByLong request);

    QuestionFindRangeDtoResponse FindRange(MDtoRequestFindRangeByLongs request);

    Task<QuestionFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByLongs request);

    QuestionInsertDtoResponse Create(QuestionInsertDtoRequest request);

    Task<QuestionInsertDtoResponse> CreateAsync(QuestionInsertDtoRequest request);

    QuestionInsertRangeDtoResponse CreateRange(QuestionInsertRangeDtoRequest request);

    Task<QuestionInsertRangeDtoResponse> CreateRangeAsync(QuestionInsertRangeDtoRequest request);

    QuestionUpdateDtoResponse Update(QuestionUpdateDtoRequest request);

    Task<QuestionUpdateDtoResponse> UpdateAsync(QuestionUpdateDtoRequest request);

    QuestionUpdateRangeDtoResponse UpdateRange(QuestionUpdateRangeDtoRequest request);

    Task<QuestionUpdateRangeDtoResponse> UpdateRangeAsync(QuestionUpdateRangeDtoRequest request);

    QuestionDeleteDtoResponse Delete(QuestionDeleteDtoRequest request);

    Task<QuestionDeleteDtoResponse> DeleteAsync(QuestionDeleteDtoRequest request);

    QuestionDeleteRangeDtoResponse DeleteRange(QuestionDeleteRangeDtoRequest request);

    Task<QuestionDeleteRangeDtoResponse> DeleteRangeAsync(QuestionDeleteRangeDtoRequest request);

    Task<QuestionSaveRangeDtoResponse> SaveRangeAsync(QuestionSaveRangeDtoRequest request);

    Task<QuestionSaveRangeDtoResponse> SaveRangeTransactionAsync(QuestionSaveRangeDtoRequest request);
}
