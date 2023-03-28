using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.DSH.DealStepHistory.Business.Dto.Request
{
    public class DealStepHistoryRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? DSHName { get; set; }
       
    }
}
