using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.CIN.CustomerInfo.Business.Dto.Request
{
    public class CustomerInfoRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? CINName { get; set; }
       
    }
}
