using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class PlainPizza : Pizza
    {
        public PlainPizza()
        {
            Console.WriteLine("Adding Dough");
        }

        public double GetCost()
        {
            return 4d;
        }

        public string GetDescription()
        {
            return "Thin Dough";
        }
    }
}
