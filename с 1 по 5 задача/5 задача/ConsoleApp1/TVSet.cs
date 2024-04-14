using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Класс Телевизор, реализующий интерфейс ISwitchable
    class TVSet : ISwitchable
    {
        /// <summary>
        /// метод включения телевизора.
        /// </summary>
        public void IInclusion()
        {
            Console.WriteLine("Телевизор включен.");
        }

        /// <summary>
        /// метод выключения телевизора.
        /// </summary>
        public void IShutdown()
        {
            Console.WriteLine("Телевизор выключен.");
        }


    }
}
