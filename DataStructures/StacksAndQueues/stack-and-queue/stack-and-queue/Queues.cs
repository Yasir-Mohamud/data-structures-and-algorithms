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
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("The queue is empty");
            }
            return Front.Value;
        }
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
