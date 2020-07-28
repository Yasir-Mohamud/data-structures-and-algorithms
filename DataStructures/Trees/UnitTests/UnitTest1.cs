using System;
using Trees;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {

        // TEST 1
        [Fact]
        public void CanInstantiateEmptyTree()
        {
            Tree<int> tree = new Tree<int>();
            Assert.Null(tree.Root);
        }

        // TEST 2
        [Fact]
        public void CanInstantiateSingleNodeRootTree()
        {
            Tree<int> tree = new Tree<int>(2);

            Assert.Equal(2, tree.Root.Value);
        }

        // TEST 3

    }
}
