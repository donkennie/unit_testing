using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_Test.Applications.Customers;
using Xunit;

namespace Unit_Test.Tests.CustomersTest
{
    public class CustomerTest
    {
        
        [Fact]
        public void CheckLegitForDiscount()
        {
            var customer = new Customer();

            Assert.InRange(customer.Age, 25, 40);

        }

        [Fact]
        public void GetOrdersByNameNotNull()
        {
            var customer = new Customer();

            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(null));

            Assert.Equal("Kill", exceptionDetails.Message);
        }


        }
}
