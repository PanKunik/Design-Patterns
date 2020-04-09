using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{

    //
    // Only one instance of object can be created.
    // Returns created instance, if exists.
    // For e.g. database connection object
    //

    public class Singleton
    {
        private static Singleton _instance;

        public static Singleton Instance()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }

        protected Singleton()
        {

        }
    }
}
