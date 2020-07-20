using System;

namespace stack_and_queue
{
    public class Stack
    {
        public Node Top { get; set; }

        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;

        }

        public Stack Pop()
        {
            Node Temp = Top;

            try
            {
               
                Top = Top.Next;
                Temp.Next = null;
            }
            catch (Exception)
            {

                throw;
            }

            return Temp.Value;
        }

    }
}
