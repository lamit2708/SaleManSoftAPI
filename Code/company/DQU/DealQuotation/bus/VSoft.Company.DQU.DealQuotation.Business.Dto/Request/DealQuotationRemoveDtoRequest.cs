using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.DQU.DealQuotation.Business.Dto.Request
{
    public class DealQuotationRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? DQUName { get; set; }
       
    }
}
