using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Интерфейс для включения/выключения
    interface ISwitchable
    {
        /// <summary>
        /// метод – включение
        /// </summary>
        void IInclusion();

        /// <summary>
        /// метод – выключение
        /// </summary>
        void IShutdown();
    }
}
