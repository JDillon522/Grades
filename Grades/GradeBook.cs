using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public List<float> grades { get; set; }
        public string Name { get; set; }

        public GradeBook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStastistics ComputeStastics()
        {
            GradeStastistics stats = new GradeStastistics();
            float sum = 0;
            
            foreach (float grade in grades)
            {
                sum += grade;
                stats.HighestGrade = Math.Max(stats.HighestGrade, grade);
                stats.LowestGrade = Math.Min(stats.LowestGrade, grade);
            }

            stats.AverageGrade = sum / (grades.Count > 0 ? grades.Count : 1);
            return stats;
        }
    }
}
