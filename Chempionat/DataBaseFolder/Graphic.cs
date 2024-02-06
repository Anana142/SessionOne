using System;
using System.Collections.Generic;

namespace Chempionat.DataBaseFolder;

public partial class Graphic
{
    public int Id { get; set; }

    public int? GraphicsDoctorId { get; set; }

    public TimeSpan? GraphicsStartVisit { get; set; }

    public TimeSpan? GraphicsEndVisit { get; set; }

    public DateTime? GraphicsData { get; set; }

    public int? GraphicsOffiseId { get; set; }

    public virtual Doctor? GraphicsDoctor { get; set; }

    public virtual Office? GraphicsOffise { get; set; }
}
