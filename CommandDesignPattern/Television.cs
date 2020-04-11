using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    class Television : ElectronicDevice
    {
        private int volume = 0;
        private bool state = false;
        public void off()
        {
            state = false;
            Console.WriteLine("TV is OFF.");
        }

        public void on()
        {
            state = true;
            Console.WriteLine("TV is ON.");
        }

        public void volumeDown()
        {
            if (state)
            {
                if (volume > 0)
                    volume--;

                Console.WriteLine("TV volume is {0}.", volume);
            }
            else
                Console.WriteLine("TV is turned off.");
        }

        public void volumeUp()
        {
            if (state)
            {
                volume++;
                Console.WriteLine("TV volume is {0}.", volume);
            }
            else
                Console.WriteLine("TV is turned off.");
        }
    }
}
