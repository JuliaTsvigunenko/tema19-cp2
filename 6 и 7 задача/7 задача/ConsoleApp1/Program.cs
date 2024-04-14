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

            // Создание объекта класса Player
            Player player = new Player();

            // Проигрывание 
            Console.WriteLine("Проигрывание:");
            player.Play();
            player.Pause();
            player.Stop();

            Console.WriteLine();

            // Запись 
            Console.WriteLine("Запись:");
            player.Record();
            player.Pause();
            player.Stop();

            Console.ReadKey();

        }
    }
}
