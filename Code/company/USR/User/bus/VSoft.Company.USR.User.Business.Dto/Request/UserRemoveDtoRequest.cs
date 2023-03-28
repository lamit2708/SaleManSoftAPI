using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.USR.User.Business.Dto.Request
{
    public class UserRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? CTMName { get; set; }
       
    }
}
