using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformance.ViewModels.ViewModels
{
    public class StudentModel
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; } = null!;

        public DateTimeOffset? SudentJoinDate { get; set; }

        public int Class { get; set; }
        public List<MarksheetModel>? StudentMarksheet { get; set; }
    //    public object Task { get; set; }
    }
}
