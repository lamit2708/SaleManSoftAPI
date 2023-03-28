using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.TEA.Team.Business.Dto.Request
{
    public class TeamRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? TEAName { get; set; }
       
    }
}
