using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.VDT.VDealTag.Business.Dto.Request
{
    public class VDealTagRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? VDTName { get; set; }
       
    }
}
