using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.DAC.DealActivity.Business.Dto.Request
{
    public class DealActivityRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? DACName { get; set; }
       
    }
}
