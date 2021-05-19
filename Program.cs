using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DexTasks1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog(2, "jeck", "Red");
            d1.GetInfo();
            d1.BarksAtTheCat();
            Console.WriteLine();

            HouseCat bars = new HouseCat(4, "Barsik", "Blue");
            bars.GetInfo();
            bars.Eat();
            Console.WriteLine();

            StreetCat cat = new StreetCat("Black");
            cat.GetInfo();
            cat.HideFromDogs();
            cat.Eat();
            Console.WriteLine();

            Mouse M1 = new Mouse();
            M1.GetInfo();
            M1.HidingFromACat();
            M1.Sleep();
            Console.WriteLine();

            Cat.QuantityCat();
            Animal.QuantityAnimal();

            Console.ReadKey();
        }
    }
}
