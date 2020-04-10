﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public abstract class ToppingsDecorator : Pizza
    {
        protected Pizza _temporaryPizza;

        public ToppingsDecorator(Pizza newPizza)
        {
            _temporaryPizza = newPizza;
        }

        public double GetCost()
        {
            return _temporaryPizza.GetCost();
        }

        public string GetDescription()
        {
            return _temporaryPizza.GetDescription();
        }
    }
}
