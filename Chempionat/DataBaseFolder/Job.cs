using System;
using System.Collections.Generic;

namespace Chempionat.DataBaseFolder;

public partial class Job
{
    public int Id { get; set; }

    public string? JobsCompanyName { get; set; }

    public virtual ICollection<Pacient> Pacients { get; set; } = new List<Pacient>();
}
