using Xunit;
using System.Collections.Generic;

namespace BDSA2021.Assignment03.Tests
{
    public class WizardTests
    {
        [Fact]
        public void Wizards_contains_2_wizards()
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Equal(12, wizards.Count);
        }

        [Fact]
        public void Two_With_Rowling()
        {
            var wizards = Queries.byRowling();
            Assert.Contains(wizards, w => w.Contains("Dumbledore") || w.Contains("Harry Potter"));
            var wizards2 = Queries.byRowlingSorted();
            Assert.Contains(wizards, w => w.Contains("Dumbledore") || w.Contains("Harry Potter"));
        }

        [Fact]
        public void Dart_Vader_1977() 
        {
            var vader = Queries.firstDarth();
            Assert.Contains(vader, y => y == 1977);
            var vader2 = Queries.firstDarthSorted();
            Assert.Contains(vader2, y => y == 1977);
        }

        [Fact]
        public void Harry_Potter()
        {
            var potters = Queries.HarryPotter();
            Assert.Contains(potters, p => p.Equals(("Dumbledore", 2001)) || p.Equals(("Harry Potter", 2001)));
            var potters2 = Queries.HarryPotterSorted();
            Assert.Contains(potters, p => p.Equals(("Dumbledore", 2001)) || p.Equals(("Harry Potter", 2001)));
        }

        [Theory]
        [InlineData("Darth Vader", "Star Wars", 1977, "George Lucas")]
        [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
        public void Spot_check_wizards(string name, string medium, int year, string creator)
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Contains(wizards, w =>
                w.Name == name &&
                w.Medium == medium &&
                w.Year == year &&
                w.Creator == creator
            );
        }
    }
}

