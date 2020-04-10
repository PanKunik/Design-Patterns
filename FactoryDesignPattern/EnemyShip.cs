using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public abstract class EnemyShip
    {
        private string name;
        private double amountOfDamage;

        public string getName()
        {
            return name;
        }

        public void setName(string newName)
        {
            name = newName;
        }

        public double getDamage()
        {
            return amountOfDamage;
        }

        public void setDamage(double newDamage)
        {
            amountOfDamage = newDamage;
        }

        public void followHeroShip()
        {
            Console.WriteLine(getName() + " is following the hero.");
        }

        public void displayEnemyShip()
        {
            Console.WriteLine(getName() + " is on the screen.");
        }

        public void enemyShipShoots()
        {
            Console.WriteLine(getName() + " attacks and does " + getDamage() + " damage.");
        }
    }
}
