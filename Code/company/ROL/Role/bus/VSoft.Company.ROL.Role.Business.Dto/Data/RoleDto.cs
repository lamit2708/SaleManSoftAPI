namespace VSoft.Company.ROL.Role.Business.Dto.Data
{
    public class RoleDto
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
