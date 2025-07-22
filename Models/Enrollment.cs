using System;
using System.Collections.Generic;

namespace SCMS_Backend.Models;

public partial class Enrollment
{
    public int EnrollmentId { get; set; }

    public int StudentId { get; set; }

    public DateTime EnrollmentDate { get; set; }

    public int CourseId { get; set; }
}
