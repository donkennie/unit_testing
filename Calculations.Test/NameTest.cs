using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculations.Test
{
    public class NameTest
    {

        [Fact]
        public void MakeFullNameTest()
        {
            var names = new Names();

            var result = names.MakeFullName("Don", "Kenny");

            Assert.Equal("Don Kenny", result);
        }
    }
}
