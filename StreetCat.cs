using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexTasks1
{
    class StreetCat : Cat
    {
        private static int count;
        public string Category { get; } = "Уличная кошка";
        public string Color { get; set; }
        public StreetCat(string color)
        {
            Color = color;
            Type = Type;
            count++;
        }
        public StreetCat(byte age, string name, string color)
        {
            Age = age;
            Name = name;
            Color = color;
            Type = Type;
            count++;
        }
        public override void GetInfo()
        {
            var age = Age != 0 ? Convert.ToString(Age) : "Неизвестно";
            var name = Name ?? "Неизвестно";
            Console.WriteLine("Тип: " + Type + "\n" + "Имя: " + name + "\n" + "Возраст: " + age + "\n" + "Цвет: " + Color + "\n" + "Количество: " + count);
        }
        public override void Eat()
        {
            Console.WriteLine("Охотиться на птиц и мышей");
        }
        public override void Sleep()
        {
            Console.WriteLine("Спать в укровном и теплом месте");
        }
        public void HideFromDogs()
        {
            Console.WriteLine("Прятаться от собак");
        }
        public static void QuantityStreetCat()
        {
            Console.WriteLine("Количество уличных котиков: " + count);
        }
    }
}
