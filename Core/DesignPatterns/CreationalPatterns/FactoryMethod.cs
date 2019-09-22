using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DesignPatterns.CreationalPatterns
{
    class MainAppFactoryMethod
    {
        public static void run()
        {
            Creator[] creators = new Creator[2];
            creators[0] = new ConcreteCreator1();
            creators[1] = new ConcreteCreator2();

            foreach (Creator c in creators)
            {
                Console.WriteLine("{0}", c.FactoryMethod().GetType().Name);
            }

        }
    }

    abstract class AbstractProduct
    {

    }

    class ConcreteProduct1 : AbstractProduct
    {

    }

    class ConcreteProduct2 : AbstractProduct
    {

    }

    abstract class Creator
    {
        public abstract AbstractProduct FactoryMethod();
    }

    class ConcreteCreator1 : Creator
    {
        public override AbstractProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }

    class ConcreteCreator2 : Creator
    {
        public override AbstractProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
