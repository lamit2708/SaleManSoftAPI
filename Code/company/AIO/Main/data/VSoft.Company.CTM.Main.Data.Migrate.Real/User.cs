using System;
using System.Collections.Generic;

namespace VSoft.Company.CTM.Main.Data.Migrate.Real;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Email { get; set; }

    public int? TeamId { get; set; }
}
