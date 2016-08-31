using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class GradeBook
    {
        List<float> grades;
        public GradeBook()
        {
            grades = new List<float>();
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        public GradeBookResult ComputeResult()
        {
            GradeBookResult res = new GradeBookResult();

            res.MaxValue = grades.Max();
            res.MinValue = grades.Min();
            res.AvgValue = grades.Average();

            return res;
        }
    }
}
