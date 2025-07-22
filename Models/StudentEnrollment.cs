using System;
using System.Collections.Generic;

namespace SCMS_Backend.Models;

public partial class StudentEnrollment
{
    public int StudentId { get; set; }

    public int EnrollmentId { get; set; }

    public virtual Enrollment Enrollment { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
