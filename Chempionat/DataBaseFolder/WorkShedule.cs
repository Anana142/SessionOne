using System;
using System.Collections.Generic;

namespace Chempionat.DataBaseFolder;

public partial class WorkShedule
{
    public int Id { get; set; }

    public TimeSpan? WorkShedulesStartDay { get; set; }

    public TimeSpan? WorkShedulesEndDay { get; set; }

    public TimeSpan? WorkShedulesStartDinner { get; set; }

    public TimeSpan? WorkShedulesStopDinner { get; set; }

    public TimeSpan? WorkShedulesTimeOneAppointment { get; set; }

    public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
}
