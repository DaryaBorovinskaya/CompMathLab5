using CompMathLab5.CalculationIntegral;

namespace CompMathLab5
{
    public class IterativeProcess
    {
        public (double, double) ApplyMethod(IIntegralCalculator integralCalculator, double accuracy, int orderAccuracy,int countOfIntervals)
        {
            int r = 2;
            double step = (integralCalculator.UpperLimit - integralCalculator.LowerLimit) / countOfIntervals,      // шаг интегрирования
                   integralCurrent = integralCalculator.CalculateIntegral(step),  // значение интеграла с текущим шагом
                   integralNextStep = integralCalculator.CalculateIntegral(step / r);  //значение интеграла с шагом в r раз меньше

            while (Math.Abs(integralCurrent - integralNextStep) / (Math.Pow(r, orderAccuracy) - 1) >= accuracy)
            {
                integralCurrent = integralNextStep;
                step /= r;
                integralNextStep = integralCalculator.CalculateIntegral(step / r);
            }

            return (integralNextStep, step/r);
        }
    }
}
