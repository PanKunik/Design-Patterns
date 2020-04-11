using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    class TVVolumeUp : Command
    {
        ElectronicDevice device;

        public TVVolumeUp(ElectronicDevice newDevice)
        {
            device = newDevice;
        }

        public void execute()
        {
            device.volumeUp();
        }
    }
}
