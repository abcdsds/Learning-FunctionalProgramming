using System;
using Xunit;
using FluentAssertions;

namespace ManagingSideEffects.Tests
{
    public class ImpureUpExtSpec
    {
        [Fact]
        public void Create_GreetingFor_Stantance()
        {
            // Arrange

            // Act
            string actual = StringExt.GreetingFor("Foo");

            // Assert
            actual.Should().Be("Hello Foo");
        }
    }
}
