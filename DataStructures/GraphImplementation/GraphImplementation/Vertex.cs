using System;
using System.Collections.Generic;
using System.Text;

namespace GraphImplementation
{
    public class Vertex<T>
    {
        public T Value { get; set; }
        public Vertex(T value)
        {
            Value = value;
        }
    }
}
