namespace InterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IInterface1 obj1 = new Class3();
            obj1.Method1();
            IInterface1 obj2 = new Class4();
            obj2.Method1();
        }
    }
}
