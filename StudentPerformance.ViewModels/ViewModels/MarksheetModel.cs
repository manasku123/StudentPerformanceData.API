using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformance.ViewModels.ViewModels
{
    public class MarksheetModel
    {
        public string? Subject { get; set; }

        public int? TotalMark { get; set; }
        public int MarkObtained { get; set; }
    }
}
