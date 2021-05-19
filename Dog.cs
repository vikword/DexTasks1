using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexTasks1
{
    class Dog : Animal 
    {
        private static int count;
        public string Subtype { get; } = "Семейство собачьих";
        public string Color { get; protected set; }
        public Dog()
        {
            Type = "Млекопитающее";
        }
        public Dog(byte age, string name, string color)
        {
            Age = age;
            Name = name;
            Color = color;
            Type = "Млекопитающее";
            count++;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Тип: " + Type + "\n" + "Подтип: " + Subtype + "\n" + "Имя: " + Name + "\n" + "Возраст: " + Age + "\n" + "Цвет: " + Color + "\n" + "Количество: " + count);
        }
        public void Sound()
        {
            Console.WriteLine("Гав");
        }
        public void BarksAtTheCat()
        {
            Console.Write("Увидел кошку: ");
            Sound();
            Sound();
        }
        public override void Eat()
        {
            Console.WriteLine("Есть");
        }
        public override void Sleep()
        {
            Console.WriteLine("Спать в будке");
        }
        public static void QuantityDog()
        {
            Console.WriteLine("Количество собак: " + count);
        }
    }
}
