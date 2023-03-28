using System;
using System.Collections.Generic;

namespace VSoft.Company.TIC.Ticket.Data.Migrate.Real;

public partial class Ticket
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public long CustomerId { get; set; }
}
