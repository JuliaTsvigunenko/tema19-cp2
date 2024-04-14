using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Интерфейс для записи 
    interface IRecodable
    {
        /// <summary>
        /// метод записи
        /// </summary>
        void Record();
        /// <summary>
        /// метод паузы
        /// </summary>
        void Pause();
        /// <summary>
        /// метод остановка
        /// </summary>
        void Stop();

    }
}
