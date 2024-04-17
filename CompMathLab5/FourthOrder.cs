using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompMathLab5
{
    public class FourthOrder : IIntegralCalculator
    {
        private double _lowerLimit;
        private double _upperLimit;
        public double LowerLimit { get { return _lowerLimit; } }
        public double UpperLimit { get { return _upperLimit; } }
        public double CalculateIntegral(double step)
        {
            double c0 = 2/45.0;
            double[] w = new double[] { 7, 32, 12, 32, 7 };
            double sum = 0;
            for (int i = 0; i < w.Length; i++)
            {
                sum += w[i] * (1 + LowerLimit + step * i) / Math.Pow(3 * (LowerLimit + step * i) + 2, 2);
            }
            return sum*c0*step;
        }
        public FourthOrder(double lowerLimit, double upperLimit)
        {
            _lowerLimit = lowerLimit;
            _upperLimit = upperLimit;
        }
    }
}
