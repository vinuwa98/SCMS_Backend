using System;
using System.Collections.Generic;

namespace SCMS_Backend.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public int DepartmentId { get; set; }
}
