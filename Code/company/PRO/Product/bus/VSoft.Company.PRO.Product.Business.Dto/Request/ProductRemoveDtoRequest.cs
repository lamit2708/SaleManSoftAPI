using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.PRO.Product.Business.Dto.Request
{
    public class ProductRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? PROName { get; set; }
       
    }
}
