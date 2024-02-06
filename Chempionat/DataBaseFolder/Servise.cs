using System;
using System.Collections.Generic;

namespace Chempionat.DataBaseFolder;

public partial class Servise
{
    public int Id { get; set; }

    public string? ServisesName { get; set; }

    public decimal? ServisesCost { get; set; }

    public virtual ICollection<TreatmentDaignosticMeasureServise> TreatmentDaignosticMeasureServises { get; set; } = new List<TreatmentDaignosticMeasureServise>();
}
