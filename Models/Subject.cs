using System;
using System.Collections.Generic;

namespace SCMS_Backend.Models;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string SubjectName { get; set; } = null!;

    public int CourseId { get; set; }
}
