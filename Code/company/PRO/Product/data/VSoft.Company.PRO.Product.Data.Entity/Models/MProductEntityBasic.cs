using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.PRO.Product.Data.Entity.Models
{
    public class MProductEntityBasic : IIdEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public double Price { get; set; }

        public int Quantity { get; set; }

        public int CategoryId { get; set; }

        public string? Description { get; set; }

        public string? Keyword { get; set; }
    }
}
