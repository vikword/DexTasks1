using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexTasks1
{
    abstract class Cat : Animal
    {
        private static int count;
        public string Subtype { get; } = "Семейство кошачьих";
        public Cat()
        {
            Type = "Млекопитающее";
            count++;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Тип: " + Type + "\n" + "Подтип" + Subtype + "\n" + "Количество: " + count);
        }
        public override void Eat()
        {
            Console.WriteLine("Есть");
        }
        public override void Sleep()
        {
            Console.WriteLine("Спать");
        }
        public static void QuantityCat()
        {
            Console.WriteLine("Количество котиков: " + count);
        }

    }
}
