﻿using Ploeh.AutoFixture;
using Xunit;

namespace DemoCode.Tests
{
    public class Strings
    {
        [Fact]
        public void BasicString()
        {
            // Arrange
            var fixture = new Fixture();
            var sut = new NameJoiner();

            var firstName = fixture.Create<string>("first");
            var lastName = fixture.Create<string>("last");

            // Act
            var result = sut.Join(firstName, lastName);

            // Assert
            Assert.Equal(firstName + ' ' + lastName, result);
        }

        [Fact]
        public void Chars()
        {
            var fixture = new Fixture();
            var anonChar = fixture.Create<char>();
        }
    }
}
