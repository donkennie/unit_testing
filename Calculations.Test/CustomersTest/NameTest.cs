using Unit_Test.Applications.Customers;
using Xunit;

namespace Unit_Test.Tests.Calculations.Test
{
    public class NameTest
    {

        [Fact]
        public void MakeFullNameTest()
        {
            var names = new Names();

            var result = names.MakeFullName("Don", "Kenny");

            Assert.Contains("Don", result);

            Assert.Equal("Don Kenny", result);
        }

        [Fact]
        public  void NickName_MustBeNull()
        {
            var names = new Names();

            names.NickName = "Value";

            Assert.NotNull(names.NickName);
        }


        [Fact]
        public void MakeFullName_AlwaysReturnValue()
        {
            var names = new Names();

            var result = names.MakeFullName("Don", "Kenny");

            Assert.NotNull(result);

            Assert.False(string.IsNullOrEmpty(result));
        }
    }
}
