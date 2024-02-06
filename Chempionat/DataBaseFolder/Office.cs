using System;
using System.Collections.Generic;

namespace Chempionat.DataBaseFolder;

public partial class Office
{
    public int Id { get; set; }

    public string? OfficesName { get; set; }

    public virtual ICollection<Graphic> Graphics { get; set; } = new List<Graphic>();

    public virtual ICollection<TreatmentDiadnosticMeasure> TreatmentDiadnosticMeasures { get; set; } = new List<TreatmentDiadnosticMeasure>();
}
