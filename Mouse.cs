using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexTasks1
{
    class Mouse : Animal
    {
        private static int count;
        public string Subtype { get; } = "Грызуны";
        public string Color { get; } = "Серый";
        public Mouse()
        {
            Type = "Млекопитающие";
            count++;
        }
        public override void Eat()
        {
            Console.WriteLine("Есть зерно или хлебные крошки");
        }

        public override void GetInfo()
        {
            Console.WriteLine("Тип: " + Type + "\n" + "Подтип: " + Subtype + "\n" + "Цвет: " + Color + "\n" + "Количество: " + count);
        }

        public override void Sleep()
        {
            Console.WriteLine("Спать в своей норке");
        }
        public void HidingFromACat()
        {
            Console.WriteLine("Прятаться от кошек");
        }
        public static void QuantityMouse()
        {
            Console.WriteLine("Количество мышей: " + count);
        }
    }
}
