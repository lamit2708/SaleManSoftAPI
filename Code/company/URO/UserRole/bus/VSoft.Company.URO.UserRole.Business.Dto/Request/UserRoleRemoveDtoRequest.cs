using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.URO.UserRole.Business.Dto.Request
{
    public class UserRoleRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? UROName { get; set; }
       
    }
}
