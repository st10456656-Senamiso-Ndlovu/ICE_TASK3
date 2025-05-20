using System;
using System.Collections.Generic;

namespace ICETASK3.Models;

public partial class Module
{
    public int ModuleId { get; set; }

    public string Qualification { get; set; } = null!;

    public string Code { get; set; } = null!;
}
