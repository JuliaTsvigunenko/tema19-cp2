using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //// Интерфейс для возведения в квадрат и извлечения квадратного корня
    interface ISquareOperations
    {
        /// <summary>
        /// возвести в квадрат
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        double Square(double a);

        /// <summary>
        /// квадратный корень
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        double SquareRoot(double a);

    }
}
