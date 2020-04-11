using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    class TVVolumeDown : Command
    {
        ElectronicDevice device;

        public TVVolumeDown(ElectronicDevice newDevice)
        {
            device = newDevice;
        }

        public void execute()
        {
            device.volumeDown();
        }
    }
}
