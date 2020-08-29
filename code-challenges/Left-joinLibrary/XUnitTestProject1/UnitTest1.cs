using System;
using System.Collections;
using System.Collections.Generic;
using static Left_joinLibrary.Class1;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanTestHappyPath()
        {
            Dictionary<string, string> dic1 = new Dictionary<string, string>();
            Dictionary<string, string> dic2 = new Dictionary<string, string>();

            dic1.Add("fond", "enamored");
            dic1.Add("outfit", "garb");
            dic2.Add("fond", "averse");

            ArrayList expected = new ArrayList();
            string[] test = new string[] { "fond", "enamored", "averse" };
            string[] test2 = new string[] { "outfit", "garb", null };
            expected.Add(test);
            expected.Add(test2);


            Assert.Equal(expected, LeftJoinMethod(dic1, dic2));
        }


        [Fact]
        public void CanTestExpectedFailure()
        {
            Dictionary<string, string> dic1 = new Dictionary<string, string>();
            Dictionary<string, string> dic2 = new Dictionary<string, string>();

            dic1.Add("fond", "enamored");
            dic1.Add("outfit", "garb");
            dic2.Add("fond", "averse");

            ArrayList expected = new ArrayList();
            string[] test = new string[] { "fond", "enamored", "averse" };
            string[] test2 = new string[] { "outfit", "garb", "garb" };
            expected.Add(test);
            expected.Add(test2);


            Assert.NotEqual(expected, LeftJoinMethod(dic1, dic2));
        }


        [Fact]
        public void CanTestEdgeCases()
        {
            Dictionary<string, string> dic1 = new Dictionary<string, string>();
            Dictionary<string, string> dic2 = new Dictionary<string, string>();

            dic1.Add("fond", "enamored");
            dic1.Add("outfit", "garb");
            dic2.Add("Fond", "averse");

            ArrayList expected = new ArrayList();
            string[] test = new string[] { "fond", "enamored", null };
            string[] test2 = new string[] { "outfit", "garb", null };
            expected.Add(test);
            expected.Add(test2);


            Assert.Equal(expected, LeftJoinMethod(dic1, dic2));
        }


    }
}
