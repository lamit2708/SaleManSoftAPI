using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.CTM.Customer.Business.Dto.Request
{
    public class CustomerRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? CTMName { get; set; }
       
    }
}
