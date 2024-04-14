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

            // Создание объектов классов
            A obj1 = new A();
            Aa obj2 = new Aa();

            // Ввод значений для obj1
            Console.Write("Введите значение x для obj1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение y для obj1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            // Вывод результатов
            Console.WriteLine("\nobj1:");
            Console.WriteLine($"{x1} + {y1} = {obj1.Add(x1, y1)}");
            Console.WriteLine($"{x1} * {y1} = {obj1.Multiply(x1, y1)}");


            // Ввод значений для obj2
            Console.Write("Введите значение x для obj2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение y для obj2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение z для obj2: ");
            double z2 = Convert.ToDouble(Console.ReadLine());

            // Вывод результатов
            Console.WriteLine("\nobj2:");
            Console.WriteLine($"{x2} + {y2} + {z2}= {obj2.Add(x2, y2)+z2}");



            //Ab obj3 = new Ab();

            //Console.WriteLine("\nobj3:");
            //Console.WriteLine($"Квадрат числа {x1}: {obj3.Square(x1)}");
            //Console.WriteLine($"Квадратный корень из {y1}: {obj3.SquareRoot(y1)}");

            Console.ReadKey();

        }
    }
}
