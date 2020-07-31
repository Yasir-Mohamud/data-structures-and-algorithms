using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinarySearchTrees
    {

        public Node<int> Root { get; set; }
        public BinarySearchTrees()
        {
            Root = null;
        }

        public BinarySearchTrees(int value)
        {
            Node<int> root = new Node<int>(value);
            Root = root;
        }
        public void Add(int value)
        {
            Node<int> temp = Root;
            Node<int> newNode = new Node<int>(value);
            if (Root == null)
            {
                Root = newNode;

            }
            else
            {
                while (temp != null)
                {

                    if (value < temp.Value)
                    {

                        if (temp.LeftChild == null)
                        {
                            temp.LeftChild = newNode;
                            break;
                        }
                        else
                        {
                            temp = temp.LeftChild;
                        }
                    }
                    else if (value > temp.Value)
                    {

                        if (temp.RightChild == null)
                        {
                            temp.RightChild = newNode;
                            break;
                        }
                        else
                        {
                            temp = temp.RightChild;
                        }
                    }


                }
            }
        }

        public bool Contains(int value)
        {
            Node<int> temp = Root;
            while (temp != null)
            {
                if (temp.Value < value)
                {
                    if (temp.LeftChild.Value == value || temp.RightChild.Value == value)
                    {
                        return true;
                    }
                }
                else if (temp.Value > value)
                {
                    if (temp.LeftChild.Value == value || temp.RightChild.Value == value)
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }
    }
}
