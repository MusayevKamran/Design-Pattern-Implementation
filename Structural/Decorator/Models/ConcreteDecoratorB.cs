using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Components;

namespace Decorator.Models
{
    // Decorators can execute their behavior either before or after the call to
    // a wrapped object.
    class ConcreteDecoratorB : Components.Decorator
    {
        public ConcreteDecoratorB(Component comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"ConcreteDecoratorB({base.Operation()})";
        }
    }
}
