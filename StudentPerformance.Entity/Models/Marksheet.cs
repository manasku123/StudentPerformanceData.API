using System;
using System.Collections.Generic;

namespace StudentPerformance.Entity.Models;

public partial class Marksheet
{
    public int MarkSheetId { get; set; }

    public int? StudentId { get; set; }

    public string? Subject { get; set; }

    public int? TotalMark { get; set; }

    public int MarkObtained { get; set; }

    public virtual StudentMaster? Student { get; set; }
}
