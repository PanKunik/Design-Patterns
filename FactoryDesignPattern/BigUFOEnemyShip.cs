using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class BigUFOEnemyShip : UFOEnemyShip
    {
        public BigUFOEnemyShip()
        {
            setName("Big UFO Enemy Ship");
            setDamage(45d);
        }
    }
}
