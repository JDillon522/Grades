using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStastistics
    {
        public GradeStastistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
        public float HighestGrade { get; set; }
        public float LowestGrade { get; set; }
        public float AverageGrade { get; set; }
    }
}
