using System;
using Xunit;
using HashTableImplamentation;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        // TEST 1
        [Fact]
        public void CanAddItemToHashTable()
        {
            HashTable<int> table = new HashTable<int>(16);
            table.Add("Josie", 9);
            Assert.NotNull(table);
        }


        // TEST 2
        [Fact]
        public void GetValue()
        {
            // arrange
            HashTable<int> table = new HashTable<int>(16);

            table.Add("Josie", 9);
            table.Add("Dog", 10);
            table.Add("Cupcake", 5);

            var result = table.Get("Dog");

            Assert.Equal(10, result);
        }


        // TEST 3
        [Fact]
        public void FindsContainedValue()
        {
            HashTable<int> table = new HashTable<int>(16);

            table.Add("Josie", 9);
            table.Add("Dog", 10);
            table.Add("Cupcake", 5);

            var contains = table.Contains("Cupcake");

            Assert.True(contains);

        }


        // TEST 4
        [Fact]
        public void CanHandleACollision()
        {
            HashTable<int> table = new HashTable<int>(10);

            table.Add("Yasir", 1);
            table.Add("Risay", 2);

            var expected = table.Contains("Yasir");

            Assert.True(expected);
          
        }


        // TEST 5
        [Fact]
        public void CanRetrieveAValuefromBucketwithinThatHasACollision()
        {
            HashTable<int> table = new HashTable<int>(10);

            table.Add("Yasir", 1);
            table.Add("Risay", 2);

            var expected = table.Get("Yasir");
         
            Assert.Equal(1, expected);
          
        }

        // TEST 6
        [Fact]
        public void CanHashKeyToAnInRangeValue()
        {
            HashTable<int> table = new HashTable<int>(10);

            int expected = table.GetHash("Yasir");

            Assert.InRange<int>(expected,0,9);
        }
    }
}
