using System;
using Xunit;
using FluentAssertions;

namespace ManagingSideEffects.Tests
{
    public class ImpureUpPureSpec
    {
        [Fact]
        public void Create_GreetingFor_Stantance()
        {
            // Arrange
            ImpureUpPure sut = new ImpureUpPure();

            // Act
            string actual = sut.GreetingFor("Foo");

            // Assert
            actual.Should().Be("Hello Foo");
        }
    }
}
