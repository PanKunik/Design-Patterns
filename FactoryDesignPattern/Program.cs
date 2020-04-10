using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        public static void doStuffEnemy(EnemyShip anEnemyShip)
        {
            anEnemyShip.displayEnemyShip();
            anEnemyShip.followHeroShip();
            anEnemyShip.enemyShipShoots();
        }

        static void Main(string[] args)
        {
            EnemyShip theEnemy;
            EnemyShipFactory shipFactory = new EnemyShipFactory();

            Console.Write("Which type of ship (U / R / B)?: ");
            string enemyShipOption = Console.ReadLine();

            theEnemy = shipFactory.makeEnemyShip(enemyShipOption);

            doStuffEnemy(theEnemy);

            Console.ReadKey();
        }
    }
}
