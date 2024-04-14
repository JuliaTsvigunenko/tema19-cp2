using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Класс, унаследованный от A и реализующий интерфейс ISquareOperations
    class Ab : A, ISquareOperations
    {
        public double Square(double a)
        {
            return a * a;
        }

        public double SquareRoot(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Невозможно извлечь квадратный корень из отрицательного числа.");
            }
            return Math.Sqrt(a);
        }
    }
}
