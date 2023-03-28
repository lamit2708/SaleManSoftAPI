using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.QUE.Question.Business.Dto.Request
{
    public class QuestionRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? QUEName { get; set; }
       
    }
}
