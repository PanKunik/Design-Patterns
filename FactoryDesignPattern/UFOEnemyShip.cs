﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class UFOEnemyShip : EnemyShip
    {
        public UFOEnemyShip()
        {
            setName("UFO Enemy Ship");
            setDamage(20d);
        }
    }
}
