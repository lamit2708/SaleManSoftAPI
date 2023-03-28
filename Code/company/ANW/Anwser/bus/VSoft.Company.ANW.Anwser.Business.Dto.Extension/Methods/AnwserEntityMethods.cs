using VSoft.Company.ANW.Anwser.Business.Dto.Data;
using VSoft.Company.ANW.Anwser.Data.Entity.Models;

namespace VSoft.Company.ANW.Anwser.Business.entity.Extension.Methods;

public static class AnwserEntityMethods
{
    public static AnwserDto GetDto(this MAnwserEntity src)
    {
        return new AnwserDto()
        {
            Id = src.Id,
            Content = src.Content,
            CreatedDate = src.CreatedDate,
            UserId = src.UserId,
            QuestionId = src.QuestionId,
        };
    }
}
