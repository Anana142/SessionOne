using System;
using System.Collections.Generic;

namespace Chempionat.DataBaseFolder;

public partial class TreatmentDaignosticMeasureServise
{
    public int TreatmentDaignosticMeasureId { get; set; }

    public int ServisesId { get; set; }

    public int? ServisesCount { get; set; }

    public virtual Servise Servises { get; set; } = null!;

    public virtual TreatmentDiadnosticMeasure TreatmentDaignosticMeasure { get; set; } = null!;
}
