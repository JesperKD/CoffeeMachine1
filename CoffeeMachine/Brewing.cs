using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    /// <summary>
    /// Class for brewing coffee
    /// </summary>
    public class Brewing
    {

        public void BrewCoffee(CoffeeMachine cm, CoffeeBean cb, Water w)
        {
            Console.WriteLine(cm.Brand + " is brewing " + w.cupsofwater +  " cups of coffee.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(cm.Brand + " is done brewing.");
        }

    }
}
