

namespace CompMathLab5
{
    public class LeftRectangles : IIntegralCalculator
    {
        private double _lowerLimit;
        private double _upperLimit;
        public double LowerLimit { get { return _lowerLimit; } }
        public double UpperLimit { get { return _upperLimit; } }
        public double CalculateIntegral(double step)
        {
            double integral = 0;
            for (double xi = _lowerLimit; xi < _upperLimit; xi += step)
                integral += (1+xi)/Math.Pow(3*xi+2,2);
                
            integral *= step;
            return integral;
        }
        public LeftRectangles(double lowerLimit, double upperLimit)
        {
            _lowerLimit = lowerLimit;
            _upperLimit = upperLimit;
        }
    }
}
