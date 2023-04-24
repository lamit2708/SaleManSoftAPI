namespace VSoft.Company.PRF.ProductFeature.Business.Dto.Data
{
    public class ProductFeatureDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
        public int ProductId { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Id} / {Name}";
        }
    }
}
