using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Domain.Product
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public double Price { get; private set; } = 0.0;
        public string Sku { get; private set; } = string.Empty;

        private Product(string name,  string description, double price, string sku)
        {
            Id= Guid.NewGuid();
            Name = name;
            Description = description;
            Price = price;
            Sku = sku;
        }

        public static Product Create(string name, string description, double price, string sku)
        {
            //todo: perform validation if any

            return new Product(name, description, price, sku);
        }

        public override string ToString()
        {
            return $"Product - Id:{Id}, Name:{Name}, Description:{Description}, Price:{Price}, Sku:{Sku}";
        }
    }
}
