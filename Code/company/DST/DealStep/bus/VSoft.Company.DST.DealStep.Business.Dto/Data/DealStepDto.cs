namespace VSoft.Company.DST.DealStep.Business.Dto.Data
{
    public class DealStepDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public override string ToString()
        {
            return $"{Id} / {Name}";
        }
    }
}
