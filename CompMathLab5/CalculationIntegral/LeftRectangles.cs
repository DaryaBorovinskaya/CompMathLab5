namespace CompMathLab5.CalculationIntegral
{
    public class LeftRectangles : IIntegralCalculator
    {
        private double _lowerLimit;
        private double _upperLimit;
        private Function _function;
        public double LowerLimit { get { return _lowerLimit; } }
        public double UpperLimit { get { return _upperLimit; } }

        public LeftRectangles(Function function, double lowerLimit, double upperLimit)
        {
            _function = function;
            _lowerLimit = lowerLimit;
            _upperLimit = upperLimit;
        }

        public double CalculateIntegral(double step)
        {
            double integral = 0;
            for (double xi = _lowerLimit; xi < _upperLimit; xi += step)
                integral += _function.MainFunction(xi);

            integral *= step;
            return integral;
        }
    }
}
