using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class VgaStream
    {
        private byte[] _stream;

        public void SetData(byte[] data)
        {
            _stream = data;
            Console.WriteLine("Set the VgaStream.");
        }

        public byte[] GetData()
        {
            Console.WriteLine("Get the VgaStream.");
            return _stream;
        }
    }
}
