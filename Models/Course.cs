﻿using System;
using System.Collections.Generic;

namespace SCMS_Backend.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; } = null!;

    public int? Duration { get; set; }

    public int SubjectId { get; set; }
}
