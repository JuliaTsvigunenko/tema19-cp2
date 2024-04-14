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


            // Создание экземпляров классов
            TVSet tvset = new TVSet();
            PersonalComputer personalcomputer = new PersonalComputer();

            // Создание списка для хранения объектов, реализующих интерфейс ISwitchable
            List<ISwitchable> equipments = new List<ISwitchable>();
            equipments.Add(tvset);
            equipments.Add(personalcomputer);

            // Вызов методов включения/выключения для каждого устройства в списке
            foreach (var equipment in equipments)
            {
                equipment.IInclusion();
                equipment.IShutdown();
            }


            Console.ReadKey();


        }
    }
}
