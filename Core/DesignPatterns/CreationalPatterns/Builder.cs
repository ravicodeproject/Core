using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DesignPatterns.CreationalPatterns
{
    class BuilderMainApp
    {
        public static void run()
        {
            Builder b1 = new ConcreteBuilder1();
            Director d = new Director();
            d.construct(b1);
            Product p1 = b1.GetResult();
            p1.show();


            Builder b2 = new ConcreteBuilder1();
            Director d2 = new Director();
            d.construct(b2);
            Product p2 = b2.GetResult();
            p2.show();

            Console.ReadKey();
        }
    }
    class Director
    {
        public void construct(Builder b)
        {
            b.buildPartA();
            b.buildPartB();
        }
    }

    #region Builder Defination
    abstract class Builder
    {
        public abstract void buildPartA();
        public abstract void buildPartB();
        public abstract Product GetResult();
    }

    class ConcreteBuilder1 : Builder
    {
        Product _product = new Product();

        public override void buildPartA()
        {
            _product.add("PartA");
        }

        public override void buildPartB()
        {
            _product.add("PartB");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

    class ConcreteBuilder2 : Builder
    {
        Product _product = new Product();

        public override void buildPartA()
        {
            _product.add("PartA");
        }

        public override void buildPartB()
        {
            _product.add("PartB");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
    #endregion

    class Product
    {
        List<string> _parts = new List<string>();

        public void add(string part)
        {
            _parts.Add(part);
        }

        public void show()
        {
            Console.WriteLine();
            foreach (string part in _parts)
                Console.WriteLine(part);
        }
    }
}
