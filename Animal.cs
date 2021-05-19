using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexTasks1
{
    abstract class Animal
    {
        private static int count;
        private byte age;

        public byte Age
        {
            get { return age; }
            protected set 
            {
                if (value > 1 && value < 30)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Введите корректный возраст от 1 до 30");
                }
            }
        }
        public Animal()
        {
            count++;
        }

        public string Name { get; set; }
        public string Type { get; protected set; }
        public abstract void GetInfo();
        public abstract void Eat();
        public abstract void Sleep();
        public static void QuantityAnimal()
        {
            Console.WriteLine("Количество животных: " + count);
        }
    }
}
