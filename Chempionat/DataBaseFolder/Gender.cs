using System;
using System.Collections.Generic;

namespace Chempionat.DataBaseFolder;

public partial class Gender
{
    public int Id { get; set; }

    public string? GendersName { get; set; }

    public virtual ICollection<Pacient> Pacients { get; set; } = new List<Pacient>();
}
