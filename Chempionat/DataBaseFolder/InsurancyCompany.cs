using System;
using System.Collections.Generic;

namespace Chempionat.DataBaseFolder;

public partial class InsurancyCompany
{
    public int Id { get; set; }

    public string? InsurancyCompaniesTitle { get; set; }

    public virtual ICollection<InsurancePolicy> InsurancePolicies { get; set; } = new List<InsurancePolicy>();
}
