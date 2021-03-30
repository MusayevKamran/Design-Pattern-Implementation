using System;
using System.Collections.Generic;
using System.Text;
using Bridge.Interfaces;

namespace Bridge.Implementations
{
    class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform B.\n";
        }
    }
}
