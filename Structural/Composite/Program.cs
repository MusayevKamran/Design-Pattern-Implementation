using System;
using Composite.Models;
using Composite.Components;


namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            // This way the client code can support the simple leaf
            // components...
            Leaf leaf = new Leaf();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(leaf);

            // ...as well as the complex composites.
            Models.Composite tree = new Models.Composite();
            Models.Composite branch1 = new Models.Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());

            Models.Composite branch2 = new Models.Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: Now I've got a composite tree:");
            client.ClientCode(tree);

            Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            client.ClientCode2(tree, leaf);
        }
    }
}
