using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_Test.Applications.Calculations;
using Xunit;

namespace Unit_Test.Tests.CalculationsTest
{
    public class CalculationTest
    {
        [Fact]
        public void FiboDoesNotIncludeZero()
        {
            var calc = new Calculation();

            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        public void FiboIncludes13()
        {
            var calc = new Calculation();

            Assert.Contains(13, calc.FiboNumbers);

        }

        [Fact]
        public void FiboDoesNotInclude4()
        {
            var calc = new Calculation();

            Assert.DoesNotContain(4, calc.FiboNumbers);

        }

        [Fact]
        public void CheckCollections()
        {
            var expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };

            var calc = new Calculation();

            Assert.Equal(expectedCollection, calc.FiboNumbers);

        }

        }
}
