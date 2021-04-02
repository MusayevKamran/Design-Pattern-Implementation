using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Interfaces
{
    // The Component interface declares an `accept` method that should take the
    // base visitor interface as an argument.
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
