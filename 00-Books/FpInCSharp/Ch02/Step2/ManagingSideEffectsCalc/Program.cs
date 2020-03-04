using System;
using System.Collections.Generic;

namespace ManagingSideEffectsCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            List<OrderLine> linesToDelete = new List<OrderLine>();

            Impure impure = new Impure();
            decimal result = impure.RecomputeTotal(order, linesToDelete);
        }
    }
}
