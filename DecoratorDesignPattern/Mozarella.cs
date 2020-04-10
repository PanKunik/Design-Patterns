using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class Mozarella : ToppingsDecorator
    {
        public Mozarella(Pizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Mozzarella");
        }

        public double GetCost()
        {
            return _temporaryPizza.GetCost() + .5d;
        }

        public string GetDescription()
        {
            return _temporaryPizza.GetDescription() + ", Mozzarella";
        }
    }
}
