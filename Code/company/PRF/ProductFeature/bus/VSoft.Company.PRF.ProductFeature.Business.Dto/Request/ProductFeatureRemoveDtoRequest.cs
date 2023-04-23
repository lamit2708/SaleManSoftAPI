using System.ComponentModel.DataAnnotations;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.PRF.ProductFeature.Business.Dto.Request
{
    public class ProductFeatureRemoveDtoRequest : MDtoRequest
    {
        [Required]
        public string? PRFName { get; set; }

    }
}
