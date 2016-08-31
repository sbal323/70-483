using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class GradeBookTests
    {
        private GradeBook GetGradeBookData()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(2);
            book.AddGrade(18);
            return book;
        }
        [TestMethod]
        public  void TestMin()
        {
            //arrange
            GradeBook book = GetGradeBookData();
            //act
            GradeBookResult res = book.ComputeResult();
            float min = res.MinValue;
            //accert
            Assert.AreEqual(min, 2);
        }
        [TestMethod]
        public void TestMax()
        {
            //arrange
            GradeBook book = GetGradeBookData();
            //act
            GradeBookResult res = book.ComputeResult();
            float max = res.MaxValue;
            //accert
            Assert.AreEqual(max, 18);
        }
        [TestMethod]
        public void TestAvg()
        {
            //arrange
            GradeBook book = GetGradeBookData();
            //act
            GradeBookResult res = book.ComputeResult();
            float avg = res.AvgValue;
            //accert
            Assert.AreEqual(avg, 10);
        }
    }
}
