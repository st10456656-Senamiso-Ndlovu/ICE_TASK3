using System;
using System.Collections.Generic;

namespace ICETASK3.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string Stnumber { get; set; } = null!;

    public string FullName { get; set; } = null!;
}
