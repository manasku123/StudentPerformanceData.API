﻿using System;
using System.Collections.Generic;

namespace StudentPerformance.Entity.Models;

public partial class StudentMaster
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public DateTimeOffset? SudentJoinDate { get; set; }

    public int Class { get; set; }

    public virtual ICollection<Marksheet> Marksheets { get; set; } = new List<Marksheet>();
}
