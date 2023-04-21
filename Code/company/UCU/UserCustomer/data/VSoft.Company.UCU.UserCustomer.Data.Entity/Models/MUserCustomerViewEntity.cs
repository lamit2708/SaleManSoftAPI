using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSoft.Company.UCU.UserCustomer.Data.Entity.Models;

public class MUserCustomerViewEntity: MUserCustomerEntityBasic
{
    public string? CustomerFullName { get; set; }

    public string? UserFullName { get; set; }

    public string? TeamName { get; set; }
}
