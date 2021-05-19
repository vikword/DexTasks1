using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexTasks1
{
    class HouseCat : Cat
    {
        private static int count;
        public string Category { get; } = "Домашняя кошка";
        public string Color { get; protected set; }
        public HouseCat(byte age, string name, string color)
        {
            Age = age;
            Name = name;
            Color = color;
            Type = Type;
            count++;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Тип: " + Type + "\n" + "Подтип: " + Subtype + "\n" + "Подтип: " + Category + "\n" + "Имя: " + Name + "\n" + "Возраст: " + Age + "\n" + "Цвет: " + Color + "\n" + "Количество: " + count);
        }
        public override void Eat()
        {
            Console.WriteLine("Есть из миски дома");
        }
        public override void Sleep()
        {
            Console.WriteLine("Спать в своем домике или на кровати хозяина");
        }
        public static void QuantityHouseCat()
        {
            Console.WriteLine("Количество домашних котиков: " + count);
        }
    }
}
