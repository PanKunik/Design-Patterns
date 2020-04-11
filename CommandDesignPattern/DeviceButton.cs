using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    class DeviceButton
    {
        Command command;

        public DeviceButton(Command newCommand)
        {
            command = newCommand;
        }

        public void press()
        {
            command.execute();
        }
    }
}
