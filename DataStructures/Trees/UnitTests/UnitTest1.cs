using System;
using System.Collections.Generic;
using Trees;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {

        // TEST 1
        [Fact]
        public void CanInstantiateEmptyTree()
        {
            Tree<int> tree = new Tree<int>();
            Assert.Null(tree.Root);
        }

        // TEST 2
        [Fact]
        public void CanInstantiateSingleNodeRootTree()
        {
            Tree<int> tree = new Tree<int>(2);

            Assert.Equal(2, tree.Root.Value);
        }

        // TEST 3
        [Fact]
        public void CanAddLeftAndRightChildToTheRoot()
        {
            Tree<int> tree = new Tree<int>(1);
            Node<int> leftChild = new Node<int>(2);
            Node<int> rightChild = new Node<int>(3);
            tree.Root.LeftChild = leftChild;
            tree.Root.RightChild = rightChild;

            Assert.Equal(3, tree.Root.RightChild.Value);
            Assert.Equal(2, tree.Root.LeftChild.Value);
        }

        // Test 4
        [Fact]
        public void CanReturnAPreOrderTraversal()
        {
            Tree<int> tree = new Tree<int>();

            Node<int> root = new Node<int>(1);
            Node<int> b = new Node<int>(2);
            Node<int> c = new Node<int>(3);
            Node<int> d = new Node<int>(4);
            Node<int> e = new Node<int>(5);
            Node<int> f = new Node<int>(6);
            Node<int> g = new Node<int>(7);

            tree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;


            List<int> order = new List<int>()
            {
                 1,2,4,5,3,6,7
            };

          

            List<int> preOrder = tree.PreOrder(tree.Root);


            Assert.Equal(order, preOrder);
        }

        // Test 5
        [Fact]
        public void CanReturnAInOrderTraversal()
        {
            Tree<int> tree = new Tree<int>();

            Node<int> root = new Node<int>(1);
            Node<int> b = new Node<int>(2);
            Node<int> c = new Node<int>(3);
            Node<int> d = new Node<int>(4);
            Node<int> e = new Node<int>(5);
            Node<int> f = new Node<int>(6);
            Node<int> g = new Node<int>(7);

            tree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;


            List<int> order = new List<int>()
            {
               4,2,5,1,6,3,7
            };



            List<int> inOrder = tree.InOrder(tree.Root);


            Assert.Equal(order, inOrder);
        }



        // Test 6
        [Fact]
        public void CanReturnAPostOrderTraversal()
        {
            Tree<int> tree = new Tree<int>();

            Node<int> root = new Node<int>(1);
            Node<int> b = new Node<int>(2);
            Node<int> c = new Node<int>(3);
            Node<int> d = new Node<int>(4);
            Node<int> e = new Node<int>(5);
            Node<int> f = new Node<int>(6);
            Node<int> g = new Node<int>(7);

            tree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;


            List<int> order = new List<int>()
            {
                 4,5,2,6,7,3,1
            };



            List<int> postOrder = tree.PostOrder(tree.Root);


            Assert.Equal(order, postOrder);
        }


        // Test 7
        [Fact]
        public void CanAddMultipleNodesToBST()
        {
            BinarySearchTrees tree = new BinarySearchTrees();
            tree.Add(100);
            tree.Add(200);
            tree.Add(50);
            tree.Add(80);
            tree.Add(30);
            tree.Add(300);
            tree.Add(130);
           

            Assert.Equal(100, tree.Root.Value);
            Assert.Equal(200, tree.Root.RightChild.Value);
            Assert.Equal(50, tree.Root.LeftChild.Value);
            Assert.Equal(80, tree.Root.LeftChild.RightChild.Value);
            Assert.Equal(30, tree.Root.LeftChild.LeftChild.Value);
            Assert.Equal(300, tree.Root.RightChild.RightChild.Value);
            Assert.Equal(130, tree.Root.RightChild.LeftChild.Value);

        }


        // Test 8
        [Fact]
        public void ShowsIfTreeContainsAValue()
        {
            BinarySearchTrees tree = new BinarySearchTrees();
            tree.Add(100);
            tree.Add(200);
            tree.Add(50);

           bool expected =  tree.Contains(50);
            Assert.True(expected);
        }
    }
}
