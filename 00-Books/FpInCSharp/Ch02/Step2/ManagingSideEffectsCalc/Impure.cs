using System.Collections.Generic;

namespace ManagingSideEffectsCalc
{
    public class Impure
    {
        public decimal RecomputeTotal(Order order, List<OrderLine> linesToDelete)
        {
            var result = 0m;
            foreach (var line in order.OrderLines)
            {
                if (line.Quantity == 0) 
                    linesToDelete.Add(line);

                else 
                    result += line.Product.Price * line.Quantity;
            }
        
            return result;
        }
    }
}