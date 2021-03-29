using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Interfaces;
using FactoryMethod.Models;

namespace FactoryMethod.Factories
{
    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
