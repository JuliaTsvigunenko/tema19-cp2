using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Интерфейс для основных арифметических операций
    interface IArithmeticOperations
    {
        /// <summary>
        /// сложение
        /// </summary>
        /// <param name="a">переменная а</param>
        /// <param name="b">переменная b</param>
        /// <returns></returns>
        double Add(double a, double b);
        /// <summary>
        /// умножение
        /// </summary>
        /// <param name="a">переменная a</param>
        /// <param name="b">переменная b</param>
        /// <returns></returns>
        double Multiply(double a, double b);

    }

   
    
}
