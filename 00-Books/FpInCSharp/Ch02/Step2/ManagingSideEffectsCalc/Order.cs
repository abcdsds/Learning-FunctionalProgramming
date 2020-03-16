using System.Collections.Generic;

namespace ManagingSideEffectsCalc
{
    public class Order
    {
        public IList<OrderLine> OrderLines { get; }

        public Order()
        {
            OrderLines = new List<OrderLine>
                {
                    new OrderLine 
                        {
                            Quantity = 0, 
                            Product = new Product { Price = 1 }
                        },
                    new OrderLine
                        {
                            Quantity = 1,
                            Product = new Product { Price = 2 }
                        },
                    new OrderLine
                        {
                            Quantity = 0,
                            Product = new Product { Price = 3 }
                        }
                };
        }
    }
}