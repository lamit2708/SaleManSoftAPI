using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSoft.Company.POR.ProductOrder.Business.Dto.Data
{
    public class ProductOrderDto
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quatity { get; set; }

        public double UnitPrice { get; set; }

        public override string ToString()
        {
            return $"{Id} / {OrderId}";
        }
    }
}
