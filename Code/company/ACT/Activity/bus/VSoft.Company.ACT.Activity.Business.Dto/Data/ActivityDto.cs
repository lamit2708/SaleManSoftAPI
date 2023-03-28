
namespace VSoft.Company.ACT.Activity.Business.Dto.Data
{
    public class ActivityDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public override string ToString()
        {
            return $"{Id} / {Name}";
        }
    }
}
