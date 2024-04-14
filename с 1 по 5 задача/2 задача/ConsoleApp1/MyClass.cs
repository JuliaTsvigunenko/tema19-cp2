using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyClass : IMyInterface
    {


        public double GetPI()
        {
            return Math.PI;
        }

        public int GetInteger()
        {
            return 25;
        }

        public double GetSquare(double x)
        {
            return x * x;
        }

        public double GetSqrt(double x)
        {
            return Math.Sqrt(x);
        }


    }
}
