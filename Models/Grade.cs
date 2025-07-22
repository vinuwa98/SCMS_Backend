using System;
using System.Collections.Generic;

namespace SCMS_Backend.Models;

public partial class Grade
{
    public int GradeId { get; set; }

    public int EnrollmentId { get; set; }

    public int SubjectId { get; set; }

    public int GradeValue { get; set; }
}
