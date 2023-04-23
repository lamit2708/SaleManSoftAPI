using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.PRF.ProductFeature.Data.Entity.Models
{
    public class MProductFeatureEntityBasic : IIdEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
        public double Price { get; set; }

        public int ProductId { get; set; }

    }
}
