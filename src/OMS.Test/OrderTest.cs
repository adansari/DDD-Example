using OMS.Domain.Customer;
using OMS.Domain.Order;
using OMS.Domain.Product;
using System.Linq;

namespace OMS.Test
{
    public class OrderTest
    {
        [Fact]
        public void shouldCreateAnOrder()
        {
            // arrange
            var customer = Customer.Create("Adil", "Adil@foo.com");

            // act
            var order = Order.Create(customer);

            // assert
            Assert.NotNull(order);
            Assert.Equal(order.CustomerId, customer.Id);
        }

        [Fact]
        public void shouldAddOrderLines()
        {
            // arrange
            var customer = Customer.Create("Adil", "Adil@foo.com");
            var fakeToy = Product.Create("Toy", "Toy upto 5 years", 10.00, "xxxxxx");

            // act
            var order = Order.Create(customer);
            order.AddOrderLine(fakeToy, 1, fakeToy.Price);

            // assert
            Assert.True(order.OrderLines.Count==1);
        }
    }
}