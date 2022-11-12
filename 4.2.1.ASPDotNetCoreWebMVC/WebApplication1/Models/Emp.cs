using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Emp
{
    public string Empcd { get; set; } = null!;

    public string? Empnm { get; set; }

    public string? Kana { get; set; }

    public int? Age { get; set; }

    public DateTime? Birthday { get; set; }

    public string? Deptcd { get; set; }
}
