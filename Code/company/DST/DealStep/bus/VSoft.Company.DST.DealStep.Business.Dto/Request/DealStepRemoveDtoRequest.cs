using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.DST.DealStep.Business.Dto.Request
{
    public class DealStepRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? DSTName { get; set; }
       
    }
}
