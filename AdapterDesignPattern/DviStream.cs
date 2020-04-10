using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class DviStream
    {
        private byte[] _stream;

        public void SetData(byte[] data)
        {
            _stream = data;
            Console.WriteLine("Set the DviStream.");
        }

        public byte[] GetData()
        {
            Console.WriteLine("Get the DviStream.");
            return _stream;
        }
    }
}
