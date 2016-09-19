using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class GradeBook
    {
        public event ItemAdded GradeAdded;
        List<float> grades;
        public GradeBook()
        {
            grades = new List<float>();
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
            GradeAdded(this, new ItemAddedEventArgs { newGrade = grade });
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

    public delegate void ItemAdded(object sender, ItemAddedEventArgs args);

    public class ItemAddedEventArgs: EventArgs
    {
        public float newGrade { get; set; }
    }
}
