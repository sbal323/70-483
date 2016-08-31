using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class GradeBookResult
    {
        public float MinValue { get; set; }
        public float MaxValue { get; set; }
        public float AvgValue { get; set; }

        public override string ToString()
        {
            return string.Format("Min: {0}\nMax:{1}\nAverage:{2}\n", MinValue, MaxValue, AvgValue); //base.ToString();
        }
    }
}
