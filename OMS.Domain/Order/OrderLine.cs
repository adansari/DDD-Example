using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Domain.Order
{
    public class OrderLine
    {
        public Guid Id { get; private set; }
        
        public Guid ProductId { get; private set; }

        public int Quantity { get; private set; } = 0;

        public double Price { get; private set; } = 0.0;

        public double Amout => Price*Quantity;

        private OrderLine(Guid productId, int quantity, double price)
        {
            Id = Guid.NewGuid();
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }

        public static OrderLine Create(Guid productId, int quantity, double price)
        {
            //todo: perform validation if any

            return new OrderLine(productId, quantity, price);
        }

        public override string ToString()
        {
            return $"OrderLine - ProductId:{ProductId}, Quantity:{Quantity}, Price:{Price}";
        }
    }
}
