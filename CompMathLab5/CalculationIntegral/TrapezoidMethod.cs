namespace CompMathLab5.CalculationIntegral
{
    public class TrapezoidMethod : IIntegralCalculator
    {
        private double _lowerLimit;
        private double _upperLimit;
        private Function _function;
        public double LowerLimit { get { return _lowerLimit; } }
        public double UpperLimit { get { return _upperLimit; } }

        public TrapezoidMethod(Function function, double lowerLimit, double upperLimit)
        {
            _function = function;
            _lowerLimit = lowerLimit;
            _upperLimit = upperLimit;
        }
        public double CalculateIntegral(double step)
        {
            double fx = 0;
            double sum = 0;
            for (double i = _lowerLimit + step; i < _upperLimit - step / 2; i += step)
            {
                fx += _function.MainFunction(i);
            }

            return step / 2 * (_function.MainFunction(_lowerLimit) + _function.MainFunction(_upperLimit) + 2 * fx);
        }
    }
}


