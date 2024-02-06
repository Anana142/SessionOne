using System;
using System.Collections.Generic;

namespace Chempionat.DataBaseFolder;

public partial class Drug
{
    public int Id { get; set; }

    public string? DrugsName { get; set; }

    public int? DrugsDose { get; set; }

    public string? DrugsVolume { get; set; }

    public virtual ICollection<TreamentDiagnosticMeasureDrug> TreamentDiagnosticMeasureDrugs { get; set; } = new List<TreamentDiagnosticMeasureDrug>();
}
