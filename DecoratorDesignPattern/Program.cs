using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    /// <summary>
    /// Decorator can add functionality to classes dynamically (at run-time)
    /// You have base Interface -> Base class (that implements interface)
    /// Then you need Decorator class which implements interface too and have member of Interface (temporary)
    /// Next are classes that inherite from Decorator class (they are expand functionality of methods)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Pizza basicPizza = new Mozarella(new TomatoSauce(new PlainPizza()));

            Console.ReadKey();
        }
    }
}
