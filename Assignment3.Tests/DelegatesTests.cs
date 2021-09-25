using System;
using Xunit;
using System.Linq;

namespace BDSA2021.Assignment03.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public void Reverse_string()
        {
            Func<string, string> write = s => new String(s.Reverse().ToArray());

            String exp = "test";
            Assert.Equal("tset" , write(exp));
        }

        [Fact]
        public void Adds_5_33_And_8_92_Returns_Sum()
        {
            Func<decimal, decimal, decimal> Add = (decimal x, decimal y) => x+y;

            var dec1 = 5.33m;
            var dec2 = 8.92m;

            Assert.Equal(14.25m, Add(dec1, dec2));
        }

        [Fact]
        public void String_00832_Equal_To_Int_832()
        {
            Func<string, int, bool> StringIntEqual = (string a, int x) => {
                return (int.TryParse(a, out int b) && b.Equals(x));
            };

            var value1 = "00832";
            var value2 = 832;

            Assert.True(StringIntEqual(value1, value2));
        }
    }
}
