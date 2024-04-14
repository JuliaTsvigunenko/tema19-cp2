using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            MyClass myClass = new MyClass();
            Console.WriteLine("PI: " + myClass.GetPI());
            Console.WriteLine("GetInteger: " + myClass.GetInteger());
            Console.WriteLine("GetSquare 9: " + myClass.GetSquare(9));
            Console.WriteLine("GetSqrt 5: " + myClass.GetSqrt(5));

            Console.ReadKey();

        }
    }
}
