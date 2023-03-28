using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.USR.User.Data.Entity.Models
{
    public class MUserEntity : IIdEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Username { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string? Email { get; set; }

        public int? TeamId { get; set; }
    }
}
