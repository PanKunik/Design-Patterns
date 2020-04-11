using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    /// <summary>
    /// With Command pattern you can set commands and execute them later (with execute() method).
    /// You create class (Reciver) which will receive command from other class (Invoker 0 with execute() method) 
    /// Commands can be executed multiple times
    /// 
    /// 1. Create device that will receive command (with TVRemote class)
    /// 2. Create command class (for e.g. TvTurnOn)
    /// 3. Create Invoker class (DeviceButton - pressing turn on button on TV remote)
    /// 
    /// When you press "Switch On" button on tv remote you are invoking command to turn on the television
    /// </summary>
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
