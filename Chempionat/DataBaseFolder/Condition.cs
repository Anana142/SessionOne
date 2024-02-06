using System;
using System.Collections.Generic;

namespace Chempionat.DataBaseFolder;

public partial class Condition
{
    public int? Id { get; set; }

    public string? ConditionsName { get; set; }

    public virtual Hospitalization? IdNavigation { get; set; }
}
