namespace VSoft.Company.URO.UserRole.Business.Dto.Data
{
    public class UserRoleDto
    {
        public long Id { get; set; }

        public int RoleId { get; set; }

        public int UserId { get; set; }

        public override string ToString()
        {
            return $"{Id} / {UserId}";
        }
    }
}
