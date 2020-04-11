using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    class TurnTVOff : Command
    {
        ElectronicDevice device;

        public TurnTVOff(ElectronicDevice newDevice)
        {
            device = newDevice;
        }

        public void execute()
        {
            device.off();
        }
    }
}
