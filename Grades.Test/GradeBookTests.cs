using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStastistics result = book.ComputeStastics();
            Assert.AreEqual(90, result.HighestGrade);
            
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);
            GradeStastistics result = book.ComputeStastics();

            Assert.AreEqual(10, result.LowestGrade);
            Assert.AreEqual(50, result.AverageGrade);
        }
        
    }
}
