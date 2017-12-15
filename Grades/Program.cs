using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook Book = new GradeBook();
            Book.AddGrade(112.33f);
            Book.AddGrade(22);
            Book.AddGrade(75);
            Book.AddGrade(112929);

            GradeStastistics stats = Book.ComputeStastics();
            Console.WriteLine($"Highest: {stats.HighestGrade}");
            Console.WriteLine($"Lowest: {stats.LowestGrade}");
            Console.WriteLine($"Average: {stats.AverageGrade}");

            Book.NameChanged += OneNameChanged;
            Book.NameChanged += OneNameChanged;

            Book.Name = "Joes book";
            Book.Name = "Someone elses book";
        }

        static void OneNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Gradebook changing name from {args.OldName} to {args.NewName}");
        }
        
    }

}
