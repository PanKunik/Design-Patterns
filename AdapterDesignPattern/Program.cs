using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
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
