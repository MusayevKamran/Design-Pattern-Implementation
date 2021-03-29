using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A2.";
        }
    }
}
