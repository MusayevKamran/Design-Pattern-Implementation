using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    // Concrete Products are created by corresponding Concrete Factories.
    class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A1.";
        }
    }
}
