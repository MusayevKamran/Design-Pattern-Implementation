using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Components;

namespace Decorator.Components
{
    // Concrete Components provide default implementations of the operations.
    // There might be several variations of these classes.
    class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }
}
