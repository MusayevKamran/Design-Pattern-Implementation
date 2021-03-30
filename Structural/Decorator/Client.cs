using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Components;

namespace Decorator
{
    public class Client
    {
        // The client code works with all objects using the Component interface.
        // This way it can stay independent of the concrete classes of
        // components it works with.
        public void ClientCode(Component component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}
