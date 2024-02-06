using System;
using System.Collections.Generic;

namespace Chempionat.DataBaseFolder;

public partial class Doctor
{
    public int Id { get; set; }

    public string? DoctorsName { get; set; }

    public string? DoctorsSurName { get; set; }

    public string? DoctorsPatronymic { get; set; }

    public DateTime? DoctorsBirthday { get; set; }

    public int? DoctorsWorkSchedulesId { get; set; }

    public string? DoctorsPasportData { get; set; }

    public string? DoctorsAddress { get; set; }

    public string? DoctorsPhoneNumber { get; set; }

    public string? DoctorsEmail { get; set; }

    public int? DoctorsRoleId { get; set; }

    public virtual Role? DoctorsRole { get; set; }

    public virtual WorkShedule? DoctorsWorkSchedules { get; set; }

    public virtual ICollection<Graphic> Graphics { get; set; } = new List<Graphic>();

    public virtual ICollection<TreatmentDiadnosticMeasure> TreatmentDiadnosticMeasures { get; set; } = new List<TreatmentDiadnosticMeasure>();
}
