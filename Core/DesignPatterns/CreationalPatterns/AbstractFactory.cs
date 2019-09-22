using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DesignPatterns.CreationalPatterns
{
    class AbstractFactoryMainApp
    {
        public static void run()
        {
            AbstractFactory factory1 = new ConcreteFactory1();

            client client1 = new client(factory1);
            client1.run();

            AbstractFactory factory2 = new ConcreteFactory2();

            client client2 = new client(factory2);
            client2.run();
        }
    }

    /*
    Provide an interface for creating families of related or dependent objects without specifying their concrete classes.

    Suppose if we take Moter bike showroom it doesn't require how the bike products made and how they assembled them

    Showroom has different bikes from different manfacturing companies.

    Here showroom is client for manufacturing companies can make orders of bike on behalf of their customers, without knowing details of manfacturing bikes.
         */

    #region AbstractFactory defination
    abstract class AbstractFactory
    {
        //declares an interface for operations that create abstract products
        public abstract AbstractProductA createProductA();
        public abstract AbstractProductB createProductB();
    }

    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA createProductA()
        {
            return new ProductA();
        }

        public override AbstractProductB createProductB()
        {
            return new ProductB();
        }
    }

    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA createProductA()
        {
            return new ProductA();
        }

        public override AbstractProductB createProductB()
        {
            return new ProductB();
        }
    }
    #endregion

    #region AbstractProductA defination
    abstract class AbstractProductA
    {

    }
    class ProductA : AbstractProductA
    {

    }
    #endregion

    #region AbstractProductB defination
    abstract class AbstractProductB
    {
        public abstract void interact(AbstractProductA producta);
    }
    class ProductB : AbstractProductB
    {
        public override void interact(AbstractProductA producta)
        {
            Console.WriteLine("This {0} class interact with {1} class", this.GetType().Name, producta.GetType().Name);
        }
    }
    #endregion


    class client
    {
        AbstractProductA _productA;
        AbstractProductB _productB;

        public client(AbstractFactory factory)
        {
            _productA = factory.createProductA();
            _productB = factory.createProductB();
        }

        public void run()
        {
            this._productB.interact(this._productA);
        }
    }
}
