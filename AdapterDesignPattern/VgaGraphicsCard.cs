using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class VgaGraphicsCard
    {
        public VgaStream GetVgaStream()
        {
            Console.WriteLine("Get VgaStream from the GPU.");

            VgaStream vgaStream = new VgaStream();
            vgaStream.SetData(new byte[] { });
            return vgaStream;
        }
    }
}
