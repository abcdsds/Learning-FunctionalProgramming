using System;
using Xunit;
using FluentAssertions;

namespace ManagingSideEffects.Tests
{
    public class ImpureUpSpec
    {
        [Fact]
        public void Create_GreetingFor_Stantance()
        {
            // Act
            ImpureUp sut = new ImpureUp();

            // Act
            string actual = sut.GreetingFor("Foo");

            // Assert
            actual.Should().Be("Hello Foo");
        }
    }
}
