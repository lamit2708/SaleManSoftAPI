namespace VSoft.Company.PRO.Product.Business.Dto.Data
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public double Price { get; set; }

        public int Quantity { get; set; }

        public int CategoryId { get; set; }

        public string? Description { get; set; }
        public string? Keyword { get; set; }
        public override string ToString()
        {
            return $"{Id} / {Name}";
        }
    }
}
