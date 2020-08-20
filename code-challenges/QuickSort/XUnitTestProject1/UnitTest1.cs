using System;
using Xunit;
using static QuickSort.Program;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        // Test 1
        [Fact]
        public void CanSortSample()
        {
            // Arrange & Act
            int[] arr = new int[] { 8, 4, 23, 42, 16, 15 };
            int[] result =  Quicksort(arr,0,arr.Length -1 );
            int[] expected = new int[] { 4, 8, 15, 16, 23, 42 };
            // Assert
            Assert.Equal(expected, result);

        }

        // TEST 2
        [Fact]
        public void CanSortReversed()
        {
            // Arrange & Act
            int[] arr = new int[] { 20, 18, 12, 8, 5, -2 };
            int[] results = Quicksort(arr,0,5);
            int[] expected = new int[] { -2, 5, 8, 12, 18, 20 };
            // Assert
            Assert.Equal(expected, results);

        }

        // TEST 3
        [Fact]
        public void CanSortFewUnique()
        {
            // Arrange & Act
            int[] arr = new int[] { 5, 12, 7, 5, 5, 7 };
            int[] results = Quicksort(arr,0,5);
            int[] expected = new int[] { 5, 5, 5, 7, 7, 12 };
            // Assert
            Assert.Equal(expected, results);

        }

        // TEST 4
        [Fact]
        public void CanSortNearlySorted()
        {
            // Arrange & Act
            int[] arr = new int[] { 2, 3, 5, 7, 13, 11 };
            int[] results = Quicksort(arr,0,5);
            int[] expected = new int[] { 2, 3, 5, 7, 11, 13 };
            // Assert
            Assert.Equal(expected, results);

        }
    }
}
    

