
using System;
using Xunit;
using static RepeatedWord.Class1;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        //TEST 1
        [Fact]
        public void CanFindRepeatedWord()
        {
            string words = "I am happy  yes am";
            string rep = FindRepeatedWord(words);
            Assert.Equal("am", rep);
        }

    
        //TEST 2
       [Fact]
        public void CanIgnoreSpecialCharacters()
        {
            string words = "I,am happy!I like that";
            string rep = FindRepeatedWord(words);
            Assert.Equal("I", rep);
        }


        // TEST 3
        [Fact]
        public void CanReturnNotFound()
        {
            string words = "I am happy ";
            string rep = FindRepeatedWord(words);
            Assert.Equal("Not Found", rep);
        }

    }
}
