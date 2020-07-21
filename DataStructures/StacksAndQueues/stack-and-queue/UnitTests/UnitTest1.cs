using System;
using Xunit;
using stack_and_queue;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void PushToStack()
        {
            Stack stack = new Stack();
            stack.Push(10);

            Assert.Equal(10, stack.Top.Value);
        }

        [Fact]
        public void PopOffStack()
        {
            Node node = new Node(10);
            node.Pop();

            Assert.IsType(null , node.Value);
        }
    }
}
