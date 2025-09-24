using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    internal interface IInterface1
    {
        void Method1();
    }
    class Class3 : IInterface1
    {
        public void Method1()
        {
            Console.WriteLine("Method1 implementation in Class3");
        }
    }

    class Class4 : IInterface1
    {
        public void Method1()
        {
            Console.WriteLine("Method1 implementation in Class4");
        }
    }
}
