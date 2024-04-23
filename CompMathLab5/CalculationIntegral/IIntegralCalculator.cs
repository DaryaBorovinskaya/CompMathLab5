

namespace CompMathLab5.CalculationIntegral
{
    public interface IIntegralCalculator
    {
        public double LowerLimit { get; }
        public double UpperLimit { get; }
        public double CalculateIntegral(double step);
    }
}
