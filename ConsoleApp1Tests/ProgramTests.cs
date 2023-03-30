using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CalculateCGPATest_A()
        {
            int[] marks = { 90, 94, 95, 98, 98 };
            float cgpa = Program.CalculateCGPA(marks);
            Assert.IsTrue(cgpa == 9.5);
        }
        [TestMethod()]
        public void CalculateCGPATest_B()
        {
            int[] marks = { 60, 70, 80, 90, 100 };
            float cgpa = Program.CalculateCGPA(marks);
            Assert.AreEqual(cgpa, 8.0);
        }
        [TestMethod()]
        public void CalculateCGPATest_C()
        {
            int[] marks = {101, 90};
            Assert.ThrowsException<Exception>(() => Program.CalculateCGPA(marks));
        }
    }
}