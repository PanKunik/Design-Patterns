using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class EnemyShipFactory
    {
        public EnemyShip makeEnemyShip(string newShipType)
        {
            if (newShipType.Equals("U"))
                return new UFOEnemyShip();
            else if (newShipType.Equals("R"))
                return new RocketEnemyShip();
            else if (newShipType.Equals("B"))
                return new BigUFOEnemyShip();
            else
                return null;
        }
    }
}
