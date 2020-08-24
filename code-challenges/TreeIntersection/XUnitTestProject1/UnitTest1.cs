using System;
using Xunit;
using static TreeIntersection.Class1;
using Trees;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanTestHappyPath()
        {
            Tree<int> tree1 = new Tree<int>();

            Node<int> root = new Node<int>(1);
            Node<int> b = new Node<int>(2);
            Node<int> c = new Node<int>(3);
            Node<int> d = new Node<int>(4);
            Node<int> e = new Node<int>(5);
            Node<int> f = new Node<int>(6);
            Node<int> g = new Node<int>(7);

            tree1.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;

            Tree<int> tree2 = new Tree<int>();

            Node<int> root2 = new Node<int>(1);
            Node<int> b2 = new Node<int>(2);
            Node<int> c2 = new Node<int>(32);
            Node<int> d2 = new Node<int>(4);
            Node<int> e2 = new Node<int>(52);
            Node<int> f2 = new Node<int>(6);
            Node<int> g2 = new Node<int>(20);

            tree2.Root = root2;

            root2.LeftChild = b2;
            root2.RightChild = c2;

            b2.LeftChild = d2;
            b2.RightChild = e2;

            c2.LeftChild = f2;
            c2.RightChild = g2;

            List<int> expected = new List<int> {1, 2, 4, 6};
            Assert.Equal(expected, TreeIntersectionMethod(tree1, tree2));
        }

        [Fact]
        public void CanTestExpectedFailure()
        {
            Tree<int> tree1 = new Tree<int>();

            Node<int> root = new Node<int>(1);
            Node<int> b = new Node<int>(2);
            Node<int> c = new Node<int>(3);
            Node<int> d = new Node<int>(4);
            Node<int> e = new Node<int>(5);
            Node<int> f = new Node<int>(6);
            Node<int> g = new Node<int>(7);

            tree1.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;

            Tree<int> tree2 = new Tree<int>();

            Node<int> root2 = new Node<int>(11);
            Node<int> b2 = new Node<int>(21);
            Node<int> c2 = new Node<int>(32);
            Node<int> d2 = new Node<int>(41);
            Node<int> e2 = new Node<int>(52);
            Node<int> f2 = new Node<int>(61);
            Node<int> g2 = new Node<int>(20);

            tree2.Root = root2;

            root2.LeftChild = b2;
            root2.RightChild = c2;

            b2.LeftChild = d2;
            b2.RightChild = e2;

            c2.LeftChild = f2;
            c2.RightChild = g2;

            List<int> expected = new List<int> { 1, 2, 4, 6 };
            Assert.NotEqual(expected, TreeIntersectionMethod(tree1, tree2));
        }


        [Fact]
        public void CanMatchNegativeNumbers()
        {
            Tree<int> tree1 = new Tree<int>();

            Node<int> root = new Node<int>(-1);
            Node<int> b = new Node<int>(-2);
            Node<int> c = new Node<int>(3);
            Node<int> d = new Node<int>(4);
            Node<int> e = new Node<int>(5);
            Node<int> f = new Node<int>(6);
           

            tree1.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
          

            Tree<int> tree2 = new Tree<int>();


            Node<int> root2 = new Node<int>(-1);
            Node<int> b2 = new Node<int>(-2);
            Node<int> c2 = new Node<int>(32);
            Node<int> d2 = new Node<int>(4);
            Node<int> e2 = new Node<int>(52);
            Node<int> f2 = new Node<int>(6);
            Node<int> g2 = new Node<int>(20);

            tree2.Root = root2;

            root2.LeftChild = b2;
            root2.RightChild = c2;

            b2.LeftChild = d2;
            b2.RightChild = e2;

            c2.LeftChild = f2;
            c2.RightChild = g2;

            List<int> expected = new List<int> { -1, -2, 4, 6 };
            Assert.Equal(expected, TreeIntersectionMethod(tree1, tree2));
        }
    }
}
