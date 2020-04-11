using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectronicDevice device = TVRemote.GetDevice();

            TurnTVOn onCommand = new TurnTVOn(device);

            DeviceButton onPressed = new DeviceButton(onCommand);

            onPressed.press();

            // --------------------------

            TVVolumeUp volumeUpCommand = new TVVolumeUp(device);

            onPressed = new DeviceButton(volumeUpCommand);

            onPressed.press();
            onPressed.press();
            onPressed.press();
            onPressed.press();

            Console.ReadKey();
        }
    }
}
