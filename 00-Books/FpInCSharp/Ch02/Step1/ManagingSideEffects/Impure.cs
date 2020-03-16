using System;
using static System.Console;

namespace ManagingSideEffects
{
    public class ImpureIO
    {
        public void SideEffects()
        {
            WriteLine("Enter your name:");
            var name = ReadLine();
            WriteLine($"Hello {name}");
        }
    }
}