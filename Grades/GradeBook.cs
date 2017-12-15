using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        private string _name;
        public List<float> grades { get; set; }
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.NewName = value;
                    args.OldName = _name;

                    NameChanged(this, args);
                }

                if (!String.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }

        public GradeBook()
        {
            _name = "empty";
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

        public event NameChangedDelegate NameChanged;

    }
}
