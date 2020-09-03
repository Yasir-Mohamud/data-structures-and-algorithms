
using System;
using Xunit;
using static RepeatedWord.Class1;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        //TEST 1
        [Fact]
        public void CanTestHappyPath()
        {
            string words = "I Am happy  yes am";
            string rep = FindRepeatedWord(words);
            Assert.Equal("am", rep);
        }

        //TEST 1
        [Fact]
        public void CanTestExpectedFailure()
        {
            string words = "I Am , happy , yes am";
            string rep = FindRepeatedWord(words);
            Assert.NotEqual(",", rep);
        }

        //TEST 2
        [Fact]
        public void CanIgnoreSpecialCharacters()
        {
            string words = "I,am happy!i ,like that";
            string rep = FindRepeatedWord(words);
            Assert.Equal("i", rep);
        }


        // TEST 3
        [Fact]
        public void CanReturnNotFound()
        {
            string words = "I am happy";
            string rep = FindRepeatedWord(words);
            Assert.Equal("Not Found", rep);
        }

    }
}
