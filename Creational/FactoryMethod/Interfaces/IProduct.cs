using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Interfaces
{
    // The Product interface declares the operations that all concrete products
    // must implement.
    public interface IProduct
    {
        string Operation();
    }
}
