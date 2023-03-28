using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.DEA.Deal.Business.Dto.Request
{
    public class DealRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? DEAName { get; set; }
       
    }
}
