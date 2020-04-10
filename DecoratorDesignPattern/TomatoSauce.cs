using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class TomatoSauce : ToppingsDecorator
    {
        public TomatoSauce(Pizza newPizza) : base(newPizza)
        {
            Console.WriteLine("Adding Tomato Sauce");
        }

        public string GetDescription()
        {
            return _temporaryPizza.GetDescription() + ", Tomato Sauce";
        }

        public double GetCost()
        {
            return _temporaryPizza.GetCost() + .25d;
        }
    }
}
