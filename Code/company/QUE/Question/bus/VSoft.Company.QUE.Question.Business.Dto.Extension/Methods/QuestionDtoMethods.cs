using VSoft.Company.QUE.Question.Business.Dto.Data;
using VSoft.Company.QUE.Question.Data.Entity.Models;

namespace VSoft.Company.QUE.Question.Business.Dto.Extension.Methods;

public static class QuestionDtoMethods
{
    public static MQuestionEntity GetEntity(this QuestionDto src, bool isForUpdate)
    {
        return new MQuestionEntity()
        {
            Id = src.Id,
            Description = src.Description,
            CreatedDate = src.CreatedDate,
            TicketId = src.TicketId,
        };
    }
}
