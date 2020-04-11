using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    interface ElectronicDevice
    {
        void on();
        void off();
        void volumeUp();
        void volumeDown();
    }
}
