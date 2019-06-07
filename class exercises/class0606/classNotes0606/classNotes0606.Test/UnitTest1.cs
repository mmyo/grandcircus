using System;
using System.Collections.Generic;
using Xunit;

namespace classNotes0606.Test
{
    public class BubbleSortTests
    {
        [Fact]
        public void EmptyListReturnsEmpty()
        {
            // Arrange
            var unsorted = new List<int>();

            // Act
            var sut = new BubbleSort();
            var sorted = sut.Sort(unsorted);

            // Assert
            Assert.Empty(sorted);
        }

        [Fact]
        public void SortedListReturnsSorted()
        {
            // Arrange
            var unsorted = new List<int>() { 1, 2, 3, 4 };

            // Act
            var sut = new BubbleSort();
            var sorted = sut.Sort(unsorted);

            // Assert
            Assert.Equal(1, sorted[0]);
            Assert.Equal(2, sorted[1]);
            Assert.Equal(3, sorted[2]);
            Assert.Equal(4, sorted[3]);
        }

        [Fact]
        public void UnSortedListReturnsSorted()
        {
            // Arrange
            var unsorted = new List<int>() { 3, 2, 1, 4 };

            // Act
            var sut = new BubbleSort();
            var sorted = sut.Sort(unsorted);

            // Assert
            Assert.Equal(1, sorted[0]);
            Assert.Equal(2, sorted[1]);
            Assert.Equal(3, sorted[2]);
            Assert.Equal(4, sorted[3]);
        }

        [Fact]
        public void NullReturnsNull()
        {
            // Arrange
            List<int> unsorted = null;

            // Act
            var sut = new BubbleSort();
            var sorted = sut.Sort(unsorted);

            // Assert
            Assert.Null(sorted);
        }

        [Fact]
        public void SingleReturnsSingle()
        {
            // Arrange
            var unsorted = new List<int>() { 2 };

            // Act
            var sut = new BubbleSort();
            var sorted = sut.Sort(unsorted);

            // Assert
            Assert.Equal(2, sorted[0]);
            Assert.Equal(1, sorted.Count);


        }
    }
}
