using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void VariablesHoldReferecne()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
            g1 = new GradeBook();

            g1.Name = "G1s name";
            Assert.AreNotEqual(g1.Name, g2.Name);
        }

        [TestMethod]
        public void IntVariablesHoldValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 200;

            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void StringComparison()
        {
            string name1 = "tommy";
            string name2 = "Tommy";

            bool result = String.Equals(name1, name2, System.StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValVsRef()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A grade book", book1.Name);


        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A grade book";
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNum(x);

            Assert.AreEqual(46, x);
        }

        private void IncrementNum(int number)
        {
            number++;
        }
        
    }
}
