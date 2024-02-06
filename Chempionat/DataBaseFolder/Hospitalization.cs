using System;
using System.Collections.Generic;

namespace Chempionat.DataBaseFolder;

public partial class Hospitalization
{
    public int Id { get; set; }

    public int? HospitalizationsPacientId { get; set; }

    public int? HospitalizationsTreatmentDiagnosticMeasuresId { get; set; }

    public DateTime? HospitalizationsDate { get; set; }

    public TimeSpan? HospitalizationsTime { get; set; }

    public int? HospitalizationsDepartmentId { get; set; }

    public string? HospitalizationsTarget { get; set; }

    public int? HospitalizationsTerm { get; set; }

    public int? HospitalizationsConditionsId { get; set; }

    public string? HospitalizationsAddInformations { get; set; }

    public bool? HospitalizationsRefusalByPacient { get; set; }

    public bool? HospitalizationsRefusalByDoctor { get; set; }

    public string? HospitalizationwhyRefusal { get; set; }

    public virtual Department? HospitalizationsDepartment { get; set; }

    public virtual Pacient? HospitalizationsPacient { get; set; }

    public virtual TreatmentDiadnosticMeasure? HospitalizationsTreatmentDiagnosticMeasures { get; set; }
}
