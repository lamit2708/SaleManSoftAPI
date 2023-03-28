using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.ROL.Role.Business.Dto.Request
{
    public class RoleRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? ROLName { get; set; }
       
    }
}
