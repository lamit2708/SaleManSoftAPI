using System;
using System.Collections.Generic;

namespace VSoft.Company.DEA.Deal.Data.Migrate.Real;

public partial class Deal
{
    public long Id { get; set; }

    public DateTime CreatedDate { get; set; }

    public long DealId { get; set; }

    public int DealStepId { get; set; }

    public int UserId { get; set; }

    public int? OrderId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }
}
