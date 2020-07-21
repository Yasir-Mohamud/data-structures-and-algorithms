using System;
using System.Collections.Generic;

namespace stack_and_queue
{
    public class Stack<T>
    {
        public Node<T> Top { get; set; }

        /// <summary>
        /// Adds a new node to the top of the stack
        /// </summary>
        /// <param name="value"> value of node </param>
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = Top;
            Top = node;

        }

        /// <summary>
        /// Checks the first node in the stack
        /// </summary>
        /// <returns>First Node on the stack </returns>
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is Empty");
            }
            return Top.Value;
        }

        /// <summary>
        /// Checks to see if stack is empty or not
        /// </summary>
        /// <returns> boolean </returns>
        public bool IsEmpty()
        {
            if (Top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks to see if stack is empty or not. If not empty it removes the first node on the stack
        /// </summary>
        /// <returns> First node on the stack </returns>
        public Node<T> Pop()
        {
            if (!IsEmpty())
            {
                Node<T> Temp = Top;
                Top = Top.Next;
                Temp.Next = null;
                return Temp;
            }
            else
            {
                throw new Exception("The stack is empty");

            }

        }

    }
}
