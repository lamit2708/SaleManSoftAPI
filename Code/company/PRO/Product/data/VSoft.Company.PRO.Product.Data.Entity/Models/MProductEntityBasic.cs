using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.PRO.Product.Data.Entity.Models
{
    public class MProductEntityBasic : IIdEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public double Price { get; set; }

        public int Quatity { get; set; }

        public string? Category { get; set; }

        public string? Description { get; set; }

        public string? Keyword { get; set; }
    }
}
