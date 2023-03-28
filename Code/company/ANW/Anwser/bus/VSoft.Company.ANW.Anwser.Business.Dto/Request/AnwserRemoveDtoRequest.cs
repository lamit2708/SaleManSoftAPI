using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.ANW.Anwser.Business.Dto.Request
{
    public class AnwserRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? ANWName { get; set; }
       
    }
}
