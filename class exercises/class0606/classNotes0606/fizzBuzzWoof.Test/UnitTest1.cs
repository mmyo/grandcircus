using FizzBuzzWoof;
using System;
using Xunit;

namespace FizzBuzzWoof.Test
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(35)]
        public void Numbers_ReturnFizzBuzzWoof(int input)
        {
            // Arrange
            // Act 
            var sut = new FBW();
            var result = sut.FizzBuzzWoof(input);

            // Assert
            Assert.Equal("fizzbuzzwoof", result);

        }

        [Theory]
        [InlineData(15)]
        public void Numbers_ReturnFizzBuzz(int input)
        {
            // Arrange
            // Act 
            var sut = new FBW();
            var result = sut.FizzBuzzWoof(input);

            // Assert
            Assert.Equal("fizzbuzz", result);

        }

        [Theory]
        [InlineData(56)]
        public void Numbers_ReturnBuzzWoof(int input)
        {
            // Arrange
            // Act 
            var sut = new FBW();
            var result = sut.FizzBuzzWoof(input);

            // Assert
            Assert.Equal("buzzwoof", result);

        }

        [Theory]
        [InlineData(21)]
        public void Numbers_ReturnFizzWoof(int input)
        {
            // Arrange
            // Act 
            var sut = new FBW();
            var result = sut.FizzBuzzWoof(input);

            // Assert
            Assert.Equal("fizzwoof", result);

        }

        [Theory]
        [InlineData(1)]
        public void NoMatches_ReturnsEmptyString(int input)
        {
            // Arrange

            // Act 
            var sut = new FBW();
            var result = sut.FizzBuzzWoof(input);

            // Assert
            Assert.Equal("", result);

        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        [InlineData(33)]

        //[InlineData(15)]
        public void MultipleOfOrContains3_ReturnsOnlyFizz(int input)
        {
            // Arrange

            // Act
            var sut = new FBW();
            var result = sut.FizzBuzzWoof(input);

            //Assert
            Assert.Equal("fizz", result);
        
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(100)]
        public void MultipleOfOrContains5_ReturnsOnlyBuzz(int input)
        {
            // Arrange

            // Act
            var sut = new FBW();
            var result = sut.FizzBuzzWoof(input);

            //Assert
            Assert.Equal("buzz", result);

        }

        [Theory]
        [InlineData(7)]
        [InlineData(14)]
        public void MultipleOfOrContains7_ReturnsOnlyWoof(int input)
        {
            // Arrange

            // Act
            var sut = new FBW();
            var result = sut.FizzBuzzWoof(input);

            //Assert
            Assert.Equal("woof", result);

        }

    }
}
