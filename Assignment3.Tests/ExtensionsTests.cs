using System;
using Xunit;

namespace BDSA2021.Assignment03.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void IsSecure_returns_true_given_string_https_url()
        {
            // A method IsSecure which extends Uri and returns 
            // true if the Uri is using Secure Hypertext Transfer Protocol.

            // Arrange 
            Uri Google = new Uri("https://www.google.com");

            // Assert
            Assert.True(Google.IsSecure());
        }

        [Fact]
        public void WordCount_return_11()
        {
            String Sentence = new String("hej 5 med 7 dig 0 hvordan 2 går 5 det");
            Assert.Equal(11, Sentence.WordCount());
        }
    }
}