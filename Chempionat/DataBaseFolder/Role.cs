using System;
using System.Collections.Generic;

namespace Chempionat.DataBaseFolder;

public partial class Role
{
    public int Id { get; set; }

    public string? RolesName { get; set; }

    public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
}
