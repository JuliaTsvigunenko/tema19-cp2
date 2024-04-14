using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Класс Player, реализующий интерфейсы IPlayable и IRecodable
    class Player : IPlayable, IRecodable
    {

        public void Play()
        {
            Console.WriteLine("Воспроизведение ...");
        }

        public void Pause()
        {
            Console.WriteLine("Пауза...");
        }

        public void Stop()
        {
            Console.WriteLine("Остановка...");
        }

        public void Record()
        {
            Console.WriteLine("Запись ...");
        }

    }
}
