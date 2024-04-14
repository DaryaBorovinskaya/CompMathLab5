

namespace CompMathLab5
{
    public class LeftRectangles
    {
        private double _lowerLimit;
        private double _upperLimit;


        private double CalculateIntegral(double step)
        {
            double integral = 0;
            for (double xi = _lowerLimit; xi < _upperLimit; xi += step)
                integral += (1+xi)/Math.Pow(3*xi+2,2);
                
            integral *= step;
            return integral;
        }
        public (double, double) ApplyMethod(double lowerLimit, double upperLimit, double accuracy)
        {
            _lowerLimit = lowerLimit;
            _upperLimit = upperLimit;

            int r = 2, orderAccuracy = 1;
            double step = (upperLimit-lowerLimit)/2,      // шаг интегрирования
                   integralCurrent = CalculateIntegral(step),  // значение интеграла с текущим шагом
                   integralNextStep = CalculateIntegral(step/r);  //значение интеграла с шагом в r раз меньше

            while(Math.Abs(integralCurrent - integralNextStep) / (Math.Pow(r,orderAccuracy)-1) >= accuracy)
            {
                integralCurrent = integralNextStep;
                step /= r;
                integralNextStep = CalculateIntegral(step/r);
            }
            
            return (integralCurrent,step);
        }
    }
}
