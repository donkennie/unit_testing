using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test.Applications.Customers
{
    public class Customer
    {
        public int GetOrdersByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Kill");
            }

            return 100;
        }

        public int Age => 35;

    }
}
