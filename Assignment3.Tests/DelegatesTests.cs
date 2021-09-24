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
    }
}
