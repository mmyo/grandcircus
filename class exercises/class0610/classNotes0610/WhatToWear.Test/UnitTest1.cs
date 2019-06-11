using System;
using Xunit;

namespace WhatToWear.Test
{
    public class UnitTest1
    {
        [Fact]
        public void EventTypeCasual_ReturnsComfy()
        {
            // Arrange
            var sut = new EventTypeWear();
            var eventType = EventEnum.Casual;

            // Act 
            var result = sut.PickMyEventClothes(eventType);

            // Assert
            Assert.Equal("comfy", result);
            
        }

        [Fact]
        public void EventTypeSemiFormal_ReturnsPolo()
        {
            // Arrange
            var sut = new EventTypeWear();
            var eventType = EventEnum.SemiFormal;

            // Act 
            var result = sut.PickMyEventClothes(eventType);

            // Assert
            Assert.Equal("polo", result);

        }

        [Fact]
        public void EventTypeFormal_ReturnsSuit()
        {
            // Arrange
            var sut = new EventTypeWear();
            var eventType = EventEnum.Formal;

            // Act 
            var result = sut.PickMyEventClothes(eventType);

            // Assert
            Assert.Equal("suit", result);

        }

        [Fact]
        public void TempLessThan54_ReturnsCoat()
        {
            // Arrange
            var sut = new TemperatureWear();
            var temperature = TempEnum.LessThan54;

            // Act 
            var result = sut.PickMyClothesBasedOnTemp(temperature);

            // Assert
            Assert.Equal("coat", result);

        }

        [Fact]
        public void TempBetween54and70_ReturnsJacket()
        {
            // Arrange
            var sut = new TemperatureWear();
            var temperature = TempEnum.Between55And69;

            // Act 
            var result = sut.PickMyClothesBasedOnTemp(temperature);

            // Assert
            Assert.Equal("jacket", result);
        }

        [Fact]
        public void TempGreaterThan70_ReturnsNoJacket()
        {
            // Arrange
            var sut = new TemperatureWear();
            var temperature = TempEnum.GreaterThan70;

            // Act 
            var result = sut.PickMyClothesBasedOnTemp(temperature);

            // Assert
            Assert.Equal("no jacket", result);

        }


    }
}
