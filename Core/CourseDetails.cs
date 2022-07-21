using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPCalculator.Core
{
    public class CourseDetails
    {
        public string Name { get; protected set; }
        public int CourseUnit { get; protected set; }
        public double Score { get; protected set; }

        public CourseDetails(string name, int courseUnit, double score)
        {
            Name = name;
            CourseUnit = courseUnit;
            Score = score;
        }
    }
}
