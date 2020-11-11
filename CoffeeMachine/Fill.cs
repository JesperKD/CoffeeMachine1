using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    /// <summary>
    /// class for filling the machine
    /// </summary>
    public class Fill
    {

        public void FillWithWater(CoffeeMachine cm ,Water w)
        {
            Console.WriteLine(w.cupsofwater + " cups of water has been added to the " + cm.Brand);
        }

        public void FillWithBeans(CoffeeMachine cm, CoffeeFilter cf, CoffeeBean cb)
        {
            Console.WriteLine("CoffeeBeans has been added in the filter of the " + cm.Brand);
        }
    }
}
