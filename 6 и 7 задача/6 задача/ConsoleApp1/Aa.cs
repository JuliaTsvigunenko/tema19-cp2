using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Класс, унаследованный от A, переопределяющий методы умножения и деления
    class Aa : A
    {
        // Переопределение метода умножения
        public new double Multiply(double a, double b)
        {
            return a * b * 2; // Умножение с удвоенным результатом
        }
    }
}
