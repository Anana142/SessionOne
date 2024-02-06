using System;
using System.Collections.Generic;

namespace Chempionat.DataBaseFolder;

public partial class InsurancePolicy
{
    public int Id { get; set; }

    public int? InsurancePoliciesCompanyId { get; set; }

    public DateTime? InsurancePoliciesStopDate { get; set; }

    public virtual InsurancyCompany? InsurancePoliciesCompany { get; set; }

    public virtual ICollection<Pacient> Pacients { get; set; } = new List<Pacient>();
}
