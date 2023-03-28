using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.POR.ProductOrder.Data.Entity.Models
{
    public class MProductOrderEntityBasic : IIdEntity<int>
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quatity { get; set; }

        public double UnitPrice { get; set; }
    }
}
