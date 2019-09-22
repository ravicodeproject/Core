using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DesignPatterns.CreationalPatterns
{
    class SingletonMainApp
    {
        public static void run()
        {
            Singleton i1 = Singleton.Instance();
            Singleton i2 = Singleton.Instance();

            if (i1 == i2)
            {
                Console.WriteLine("Objects are the same instance.");
            }
        }
    }

    class Singleton
    {
        private static Singleton _instance;

        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
                return _instance;

            return _instance;
        }
    }
}
