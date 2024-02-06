using System;
using System.Collections.Generic;

namespace Chempionat.DataBaseFolder;

public partial class TreamentDiagnosticMeasureDrug
{
    public int TreamentDiagnosticMeasureId { get; set; }

    public int DrugsId { get; set; }

    public int? DrugsCount { get; set; }

    public virtual Drug Drugs { get; set; } = null!;

    public virtual TreatmentDiadnosticMeasure TreamentDiagnosticMeasure { get; set; } = null!;
}
