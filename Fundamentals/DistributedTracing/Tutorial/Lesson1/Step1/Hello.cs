using System;

namespace Step1
{
    public class Hello
    {
        public void SayHello(string helloTo)
        {
            var msg = HelloFor(helloTo);
            Console.WriteLine(HelloFor(msg));
        }

        private string HelloFor(string helloTo)
        {
            return $"Hello, {helloTo}!";
        }
    }
}