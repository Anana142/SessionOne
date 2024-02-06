using System;
using System.Collections.Generic;

namespace Chempionat.DataBaseFolder;

public partial class TreatmentDiadnosticMeasure
{
    public int Id { get; set; }

    public int? TreatmentDiadnosticMeasuresPacientId { get; set; }

    public DateTime? TreatmentDiadnosticMeasuresDate { get; set; }

    public TimeSpan? TreatmentDiadnosticMeasuresTime { get; set; }

    public int? TreatmentDiadnosticMeasuresDoctorId { get; set; }

    public int? TreatmentDiadnosticMeasuresTypeId { get; set; }

    public int? TreatmentDiadnosticMeasuresOfficeId { get; set; }

    public string? TreatmentDiadnosticMeasuresTitle { get; set; }

    public string? TreatmentDiadnosticMeasuresResult { get; set; }

    public string? TreatmentDiadnosticMeasuresRecommendations { get; set; }

    public virtual ICollection<Hospitalization> Hospitalizations { get; set; } = new List<Hospitalization>();

    public virtual ICollection<TreamentDiagnosticMeasureDrug> TreamentDiagnosticMeasureDrugs { get; set; } = new List<TreamentDiagnosticMeasureDrug>();

    public virtual ICollection<TreatmentDaignosticMeasureServise> TreatmentDaignosticMeasureServises { get; set; } = new List<TreatmentDaignosticMeasureServise>();

    public virtual Doctor? TreatmentDiadnosticMeasuresDoctor { get; set; }

    public virtual Office? TreatmentDiadnosticMeasuresOffice { get; set; }

    public virtual TreatmentDiagnosticMeasureType? TreatmentDiadnosticMeasuresType { get; set; }
}
