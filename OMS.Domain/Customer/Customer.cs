using OMS.Domain.Order;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Domain.Customer
{
    public class Customer
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; } = string.Empty;
        public string Email { get; private set;} = string.Empty;

        private Customer(string name, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
        }

        public static Customer Create(string name, string email)
        {
            //todo: perform validation if any

            return new Customer(name, email);
        }

        public override string ToString()
        {
            return $"Customer - Id:{Id}, Name:{Name}, Email:{Email}";
        }
    }
}
