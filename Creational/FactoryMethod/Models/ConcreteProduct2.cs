using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
