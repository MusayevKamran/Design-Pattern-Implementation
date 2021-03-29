 using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    // Concrete Products provide various implementations of the Product
    // interface.
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
