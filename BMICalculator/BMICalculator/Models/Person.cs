using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator.Models
{
    public class Person
    {
        public double Weight { get; set; }
        public double Height { get; set; }

        public double CalculateBMI()
        {
            return Weight / (Weight * Height);
        }
    }

}
