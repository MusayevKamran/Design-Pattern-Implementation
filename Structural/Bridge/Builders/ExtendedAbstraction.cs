using System;
using System.Collections.Generic;
using System.Text;
using Bridge.Interfaces;

namespace Bridge.Builders
{
    // You can extend the Abstraction without changing the Implementation
    // classes.
    class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) 
            : base(implementation) { }

        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" +
                   base._implementation.OperationImplementation();
        }
    }
}
