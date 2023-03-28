using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.PRC.ProductCategory.Business.Dto.Request
{
    public class ProductCategoryRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? CTMName { get; set; }

    }
}
