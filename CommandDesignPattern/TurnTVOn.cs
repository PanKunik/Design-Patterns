using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    class TurnTVOn : Command
    {
        ElectronicDevice device;

        public TurnTVOn(ElectronicDevice newDevice)
        {
            device = newDevice;
        }

        public void execute()
        {
            device.on();
        }
    }
}
