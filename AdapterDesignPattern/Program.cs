using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    /// <summary>
    /// The VgaGraphicsCard can output ONLY the VgaStream class.
    /// The DviMonitor can accept as input ONLY the DviStream class.
    /// There is needed an adapter (VgaGraphicsCardAdapter) to convert the VgaStream from VgaGraphicsCard to DviStream for DviMonitor.
    /// 
    /// Adapter takes as the argument the Adaptee class and allows Adaptee to communicate with Target class
    /// (VgaGraphicsCardAdapter)     (VgaGraphicsCard)                                      (DviMonitor)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            VgaGraphicsCard vgaGraphicsCard = new VgaGraphicsCard();
            DviMonitor dviMonitor = new DviMonitor();
            VgaGraphicsCardAdapter vgaGraphicsCardAdapter = new VgaGraphicsCardAdapter(vgaGraphicsCard);
            dviMonitor.SetInput(vgaGraphicsCardAdapter.GetDviStream());

            Console.ReadKey();
        }
    }
}
