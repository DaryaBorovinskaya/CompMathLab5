

namespace CompMathLab5.CalculationIntegral
{
    public class FourthOrder : IIntegralCalculator
    {
        private double _lowerLimit;
        private double _upperLimit;
        private Function _function;
        public double LowerLimit { get { return _lowerLimit; } }
        public double UpperLimit { get { return _upperLimit; } }

        public FourthOrder(Function function, double lowerLimit, double upperLimit)
        {
            _function = function;
            _lowerLimit = lowerLimit;
            _upperLimit = upperLimit;
        }

        public double CalculateIntegral(double step)
        {
            double x = LowerLimit;
            double c0 = 2 / 45.0;
            double[] w = new double[] { 7, 32, 12, 32, 7 };
            double sum = 0;
            double result = 0;
            while (true)
            {
                x -= step;
                for (int i = 0; i < w.Length; i++)
                {
                    x += step;
                    sum += w[i] * _function.MainFunction(x);
                }
                result += sum * c0 * step;
                sum = 0;
                if (x + step / 2 > UpperLimit) 
                    break;
            }
            return result;
        }
    }
}
