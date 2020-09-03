using System;
using System.Collections.Generic;


namespace HashTableImplamentation
{
    public class HashTable<T>
    {

            public LinkedList<LinkedListNode<Node<T>>>[] Map { get; set; }
            public HashTable(int size)
            {
                Map = new LinkedList<LinkedListNode<Node<T>>>[size];
            }

            /// <summary>
            /// Computes a hash integer from a given key value
            /// </summary>
            /// <param name="key">the given key to hash</param>
            /// <returns>index of the array placement</returns>
            public int GetHash(string key)
            {
                // Determine our alogirithm for our hash.
                // a string is a list of char
                // a char is a numeric value

                int total = 0;
                for (int i = 0; i < key.Length; i++)
                {
                    total += key[i];
                }

                int primeValue = total * 599;
                int index = primeValue % Map.Length;

                return index;

            }

            /// <summary>
            /// Takes in a key and value and adds them to a HashTable
            /// </summary>
            /// <param name="key"> the key to be added </param>
            /// <param name="value"> the  value to be added </param>
            public void Add(string key, T value)
            {
                int index = GetHash(key);
                Node<T> htNode = new Node<T>(value, key);
                LinkedListNode<Node<T>> node = new LinkedListNode<Node<T>>(htNode);

                if (Map[index] is null)
                {
                    // instantiate a new linked list
                    Map[index] = new LinkedList<LinkedListNode<Node<T>>>();

                }

                Map[index].AddLast(node);

            }

            /// <summary>
            /// Gets the value of the key that was inputted
            /// </summary>
            /// <param name="key"> the key you want to get the value of</param>
            /// <returns> the value of the key</returns>
            public T Get(string key)
            {
                int index = GetHash(key);
                if (!(Map[index] is null))
                {
                    if (Map[index].Count == 1)
                    {
                        var first = Map[index].First;
                        // {LinkedListNode} {HashtTableNode Value} {Property}
                        return first.Value.Value.Value;
                    }
                    else
                    {
                        var current = Map[index].First;
                        while (current != null)
                        {
                            if (current.Value.Value.Key == key)
                            {
                                return current.Value.Value.Value;
                            }
                            current = current.Next;
                        }
                    }
                }
                return default;
            }

        /// <summary>
        /// Checks to see if a key is in the HashTable
        /// </summary>
        /// <param name="key">the key to be looked for </param>
        /// <returns> false if not found, true if found</returns>
            public bool Contains(string key)
            {
                int index = GetHash(key);

                var location = Map[index];

                if (!(location is null))
                {
                    var current = Map[index].First;

                    while (current != null)
                    {
                        if (current.Value.Value.Key == key)
                        {
                            return true;
                        }

                    }
                }
                return false;
            }
     }
    


}

