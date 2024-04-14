using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Класс Персональный компьютер, реализующий интерфейс ISwitchable
    class PersonalComputer : ISwitchable
    {

        /// <summary>
        /// метод включения Компьютера.
        /// </summary>
        public void IInclusion()
        {
            Console.WriteLine("Компьютер включен.");
        }

        /// <summary>
        /// метод выключения Компьютера.
        /// </summary>
        public void IShutdown()
        {
            Console.WriteLine("Компьютер выключен.");
        }

    }
}
