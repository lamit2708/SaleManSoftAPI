using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.PRI.Priority.Business.Dto.Request
{
    public class PriorityRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? PRIName { get; set; }
       
    }
}
