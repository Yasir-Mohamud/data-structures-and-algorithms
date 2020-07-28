using System;
using System.Collections.Generic;

namespace Trees
{
    public class Tree<T>
    {
        public Node<T> Root { get; set; }
        public Tree()
        {

        }

        public Tree(T value)
        {
            Node<T> root = new Node<T>(value);
            Root = root;
        }

        public List<T> Preorder( Node<T> root)
        {
            List<T> traversal = new List<T>();
            PreOrder(traversal, root);
            return traversal;

        }

        private void PreOrder(List<T> traversal, Node<T> root)
        {
            traversal.Add(root.Value);

            if (root.LeftChild != null)
            {
                PreOrder(traversal, root.LeftChild);
            }

            if (root.RightChild != null)
            {
                PreOrder(traversal, root.RightChild);
            }

        }
    }
}
