using OMS.Domain.Customer;
using OMS.Domain.Product;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Domain.Order
{
    public class Order
    {
        public Guid Id { get; private set; }
        
        public Guid CustomerId { get; private set; }

        public HashSet<OrderLine> OrderLines { get; private set; } = new HashSet<OrderLine>();

        private Order(Guid customerId) {
            Id = Guid.NewGuid();
            this.CustomerId = customerId;
        }

        public Order AddOrderLine(Product.Product product, int quantity, double price) 
        {
            OrderLines.Add(OrderLine.Create(product.Id, quantity, price));
            return this;
        }

        public static Order Create(Customer.Customer customer)
        {
            //todo: perform validation if any

            return new Order(customer.Id);
        }

        public override string ToString()
        {
            var returnValue = new StringBuilder($"OrderId:{Id}, CustomerId:{CustomerId}, Items:{OrderLines.Count}");
            returnValue.AppendLine("");
            foreach (var line in OrderLines) {
                returnValue.AppendLine(line.ToString());
            }

            return returnValue.ToString();
        }
    }
}
