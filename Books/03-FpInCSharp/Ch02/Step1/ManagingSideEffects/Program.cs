using System;

namespace ManagingSideEffects
{
    class Program
    {
        static void Main(string[] args)
        {
            Impure impure = new Impure();
            impure.SideEffects();

            ImpureUpPure upPure = new ImpureUpPure();
            upPure.SideEffects();

            ImpureUpExt upExt = new ImpureUpExt();
            upExt.SideEffects();
        }
    }
}
