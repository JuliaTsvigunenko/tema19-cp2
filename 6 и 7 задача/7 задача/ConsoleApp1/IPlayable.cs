using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Интерфейс для проигрывания 
    interface IPlayable
    {
        /// <summary>
        /// метод воспроизведение
        /// </summary>
        void Play();
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
