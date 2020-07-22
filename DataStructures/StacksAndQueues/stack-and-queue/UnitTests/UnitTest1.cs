using System;
using Xunit;

using stack_and_queue;

namespace UnitTests
{
    public class UnitTest1
    {

        /// <summary>
        /// STACK TESTS
        /// </summary>


        //Test 1
        [Fact]
        public void CanPushToStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);

            Assert.Equal(10, stack.Top.Value);
        }

        // Test 2
        [Fact]
        public void CanPushMultipleValuesOnToStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(11);
            stack.Push(12);
            Assert.Equal(12, stack.Top.Value);

            stack.Push(13);
            Assert.Equal(13, stack.Top.Value);
        }

        // Test 3
        [Fact]
        public void CanPopOffStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(11);
            stack.Push(12);

            stack.Pop();
            Assert.Equal(11, stack.Top.Value);

        }

        // Test 4
        [Fact]
        public void CanEmptyStackAfterMultiplePops()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(11);
            stack.Push(12);

            stack.Pop();
            stack.Pop();
            stack.Pop();

            bool expected = true;

            Assert.Equal(expected, stack.IsEmpty());
        }

        // test 5

        [Fact]

        public void PeekNextItemOnStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);

            Assert.Equal(10, stack.Peek());
        }

        // Test 6
        [Fact]

        public void InstantiateEmptyStack()
        {
            Stack<int> stack = new Stack<int>();

            bool expected = true;

            Assert.Equal(expected, stack.IsEmpty());
        }

        // Test 7

        [Fact]
        public void EmptyStackThrowsException()
        {
            Stack<int> stack = new Stack<int>();

            var popResult = Assert.Throws<Exception>(() => stack.Pop());
            var peekResult = Assert.Throws<Exception>(() => stack.Peek());

            string expected = "The stack is empty";
            Assert.Equal(expected, popResult.Message);
            Assert.Equal(expected, peekResult.Message);


        }


        /// <summary>
        /// QUEUE TESTS
        /// </summary>

        // Test 8

        [Fact]

        public void CanEnqueueIntoQueue()
        {
            Queues<int> queue = new Queues<int>();
            queue.Enqueue(10);

            Assert.Equal(10, queue.Front.Value);
        }

        // Test 9

        [Fact]

        public void EnqueueMultipleValues()
        {
            Queues<int> queue = new Queues<int>();
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(12);
            Assert.Equal(12, queue.Rear.Value);
            queue.Enqueue(20);
            Assert.Equal(10, queue.Front.Value);
        }

        // Test 10

        [Fact]

        public void CanDequeueOutOfQueue()
        {
            Queues<int> queue = new Queues<int>();
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(12);

            Node<int> returned = queue.Dequeue();
            int expected = 10;
            Assert.Equal(expected, returned.Value);
        }


        // Test 11
        [Fact]

        public void PeekIntoQueueAndSeeExpectedValue()
        {
            Queues<int> queue = new Queues<int>();
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(12);

            int returned = queue.Peek();
            int expected = 10;
            Assert.Equal(expected, returned);
        }

        // Test 12

        [Fact]

        public void EmptyQueueAfterMultipleDequeues()
        {
            Queues<int> queue = new Queues<int>();
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(12);

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            bool expected = true;

            Assert.Equal(expected, queue.IsEmpty());

        }

        // Test 13

        [Fact]

        public void InstantiateEmptyQueue()
        {
            Queues<int> queue = new Queues<int>();
            bool expected = true;

            Assert.Equal(expected, queue.IsEmpty());
        }

        // test 14 

        [Fact]

        public void EmptyQueueThrowsException()
        {
            Queues<int> queue = new Queues<int>();

            var dequeueResult = Assert.Throws<Exception>(() => queue.Dequeue());
            var peekResult = Assert.Throws<Exception>(() => queue.Peek());

            string expected =("The queue is empty");
            Assert.Equal(expected, dequeueResult.Message);
            Assert.Equal(expected, peekResult.Message);

        }

    }
}
