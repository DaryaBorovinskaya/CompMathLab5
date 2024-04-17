using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompMathLab5
{
    public interface IIntegralCalculator
    {
        public double LowerLimit { get; }
        public double UpperLimit { get; }
        public double CalculateIntegral(double step);
    }
}
