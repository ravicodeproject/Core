﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DesignPatterns.CreationalPatterns
{
   class PrototypeMainApp
    {
        public static void run()
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.clone();
            Console.WriteLine("Cloned: {0}", c1.id);


            ConcretePrototype1 p2 = new ConcretePrototype1("II");
            ConcretePrototype1 c2 = (ConcretePrototype1)p2.clone();
            Console.WriteLine("Cloned: {0}", c2.id);
        }
    }


   abstract class Prototype
    {
        private string _id;

        public Prototype(string id)
        {
            _id = id;
        }

        public string id
        {
            get
            {
                return _id;
            }
        }

        public abstract Prototype clone();
    }

    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id) : base(id)
        {

        }

        public override Prototype clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string id) : base(id)
        {

        }

        public override Prototype clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
