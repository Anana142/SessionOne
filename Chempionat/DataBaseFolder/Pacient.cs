using System;
using System.Collections.Generic;

namespace Chempionat.DataBaseFolder;

public partial class Pacient
{
    public int IdmedicalCard { get; set; }

    public byte[]? PacientsPhoto { get; set; }

    public string? PacientsSurName { get; set; }

    public string? PacientsName { get; set; }

    public string? PacientsPatronymic { get; set; }

    public string? PacientsPasportData { get; set; }

    public DateTime? PacientsBirthday { get; set; }

    public int? PacientsGenderId { get; set; }

    public string? PacientsAddress { get; set; }

    public string? PacientsPhoneNumber { get; set; }

    public string? PacientsEmail { get; set; }

    public int? PacientsInsurancePolicyId { get; set; }

    public int? PacientsJobId { get; set; }

    public DateTime? PacientCardIssueDate { get; set; }

    public virtual ICollection<Hospitalization> Hospitalizations { get; set; } = new List<Hospitalization>();

    public virtual Gender? PacientsGender { get; set; }

    public virtual InsurancePolicy? PacientsInsurancePolicy { get; set; }

    public virtual Job? PacientsJob { get; set; }
}
