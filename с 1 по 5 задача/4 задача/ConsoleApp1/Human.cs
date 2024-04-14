using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Класс человек
    class Human : Reflections, Razgovor
    {
        public void Razgovor()
        {
            Console.WriteLine("Говорит громко - Я люблю программирование!");
            Console.WriteLine("Говорит нормально - Меньше люблю компьютерный игры");
        }


        public void Reflections()
        {
            Console.WriteLine("Думает - А C# больше всего");
        }

    }
}
