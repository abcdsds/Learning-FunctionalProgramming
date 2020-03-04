using System;

namespace CreatingConsistentObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //new NullReferenceException
            // Object reference not set to an instance of an object.
            string x = null;
            int length = x.Length;

            // CreatingConsistentObject_Problem1.Student s = new CreatingConsistentObject_Problem1.Student();
            // s.Name = null;
        }
    }
}
