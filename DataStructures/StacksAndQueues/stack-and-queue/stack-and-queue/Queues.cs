using System;
using System.Collections.Generic;
using System.Text;

namespace stack_and_queue
{
   public class Queues<T>
    {
        public Node<T> Front { get; set; }
        public Node<T> Rear { get; set; }

        public Queues()
        {
            Rear = Front;
        }

        /// <summary>
        /// Adds node to the rear of the queue.
        /// </summary>
        /// <param name="value"> node value </param>
        public void Enqueue(T value)
        {
            Node<T> node = new Node<T>(value);
            if(Front == null)
            {
                Front = node;
                Rear = node;

            }
            else
            {
                Rear.Next = node;
                Rear = node;

            }
        }

        /// <summary>
        /// Checks the front node in queue
        /// </summary>
        /// <returns>value of the front node </returns>
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("The queue is empty");
            }
            return Front.Value;
        }

        /// <summary>
        /// Checks if queue is empty
        /// </summary>
        /// <returns>boolean</returns>
        public bool IsEmpty()
        {
            if(Front == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Removes a node from the front of the queue
        /// </summary>
        /// <returns> Front node</returns>
        public Node<T> Dequeue()
        {
            if(!IsEmpty())
            {
                Node<T> Temp = Front;
                Front = Front.Next;
                Temp.Next = null;
                return Temp;
            }
            else
            {
                throw new Exception("The queue is empty");
            }
        }
    }
}
