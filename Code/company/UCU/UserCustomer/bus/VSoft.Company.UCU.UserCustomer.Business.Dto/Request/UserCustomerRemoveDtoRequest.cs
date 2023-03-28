using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.UCU.UserCustomer.Business.Dto.Request
{
    public class UserCustomerRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? UCUName { get; set; }
       
    }
}
