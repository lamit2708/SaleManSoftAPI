using VSoft.Company.ANW.Anwser.Business.Dto.Data;
using VSoft.Company.ANW.Anwser.Data.Entity.Models;

namespace VSoft.Company.ANW.Anwser.Business.Dto.Extension.Methods;

public static class AnwserDtoMethods
{
    public static MAnwserEntity GetEntity(this AnwserDto src, bool isForUpdate)
    {
        return new MAnwserEntity()
        {
            Id = src.Id,
            Content = src.Content,
            CreatedDate = src.CreatedDate,
            UserId = src.UserId,
            QuestionId = src.QuestionId,
        };
    }
}
