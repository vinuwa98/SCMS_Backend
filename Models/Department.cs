using System;
using System.Collections.Generic;

namespace SCMS_Backend.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;
}
