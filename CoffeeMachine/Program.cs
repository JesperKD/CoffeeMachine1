using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine cm = new CoffeeMachine("MochaMaster");
            Fill fill = new Fill();
            BoilWater boilwater = new BoilWater();
            Brewing brewing = new Brewing();
            CoffeeBean cb = new CoffeeBean();
            Water water = new Water();
            CoffeeFilter cf = new CoffeeFilter();

            cm.TurnOn();

            Console.WriteLine("How many cups of coffee would you like to brew?");
            water.cupsofwater = int.Parse(Console.ReadLine());
            Console.WriteLine();

            fill.FillWithWater(cm, water);
            fill.FillWithBeans(cm, cf, cb);
            Console.WriteLine();

            Console.WriteLine("Press ENTER to brew coffee");
            Console.ReadKey();
            Console.WriteLine();

            boilwater.Boil(water);
            Console.WriteLine();
            brewing.BrewCoffee(cm, cb, water);
            cm.TurnOff();

            Console.ReadKey();

        }
    }
}
