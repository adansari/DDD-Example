using OMS.Domain.Customer;
using OMS.Domain.Order;
using OMS.Domain.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var customer = Customer.Create("Adil", "Adil@foo.com");
            var toy = Product.Create("Toy", "Toy upto 5 years", 10.00, "xxxxxx");
            var laptop = Product.Create("Laptop", "15|i5 12 gen|8GB|1TB", 1000.00, "xxxxxx");

            var order = Order.Create(customer);
            order.AddOrderLine(toy, 1, toy.Price);
            order.AddOrderLine(laptop, 1, laptop.Price);

            Console.WriteLine("================ Customer =================");
            Console.WriteLine(customer);
            Console.WriteLine("================ Products =================");
            Console.WriteLine(toy);
            Console.WriteLine(laptop);
            Console.WriteLine("================= Order ===================");
            Console.WriteLine(order);
            Console.WriteLine("===========================================");
        }
    }
}
