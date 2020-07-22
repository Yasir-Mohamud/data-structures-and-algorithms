using System;
using Xunit;
using static ArrayCodeChallenge.Program;

namespace UnitTest 
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 4, 5 } , 3 , new int[] { 1, 2, 3, 4, 5 })]
        public void Test1(int[] arr , int number ,int[] expected)
        {

           int[] newArr =  InsertArrayShift(arr, number);
            Assert.Equal(expected, newArr);
        }
    }
}
