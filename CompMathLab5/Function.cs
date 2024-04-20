using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompMathLab5
{
    public class Function
    {
        public double MainFunction(double x)
        {
            return (1 + x) / Math.Pow(2 + 3 * x, 2);
        }
    }
}
