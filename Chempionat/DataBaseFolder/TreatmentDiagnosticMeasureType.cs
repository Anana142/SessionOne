using System;
using System.Collections.Generic;

namespace Chempionat.DataBaseFolder;

public partial class TreatmentDiagnosticMeasureType
{
    public int Id { get; set; }

    public string? TreatmentDiagnosticMeasureTypesName { get; set; }

    public virtual ICollection<TreatmentDiadnosticMeasure> TreatmentDiadnosticMeasures { get; set; } = new List<TreatmentDiadnosticMeasure>();
}
