# Trees
<!-- Short summary or background information -->
Trees is a nonlinear data structure where the first Node or begining is called a `Root` and is made up of child nodes called `Left Child` which is located on 
the left side and `Right Child` which is located on the right, `Leaf` is a Node that doesn't have any children.

## Challenge 15 Challenge 15: Binary Tree and BST Implementation 
<!-- Description of the challenge -->
A .Net class Library project that implements a Tree class(which is generic), a Node class(which is generic) and a BinarySearchTree class with unit tests.

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->

Big O
___

|Methods|Time|Space|
|-----|
|Tree.PreOrder(Root)| O(n)| O(1)|
|Tree.InOrder(Root)| O(n)|  O(1)|
|Tree.PostOrder(Root)| O(n)|  O(1)|
|BinarySearchTree.Add(value)| O(n)| O(1)
|BinarySearchTree.Contains(value)| O(log n)| O(1)

## API
<!-- Description of each method publicly available in each of your trees -->
- Tree.PreOrder(Root) : traverses over a tree from root, to left children then right and return collection of nodes
 - Tree.InOrder(Root) : traverses over a tree from left children, then root then right and return collection of nodes
 - Tree.PostOrder(Root) : traverses over a tree from left children then right then root and return collection of nodes
 - -BinarySearchTree.Add(value) : traverses through tree and add value to the tree.
 - BinarySearchTree.Contains(value) : traverse over tree and checks if value is in the tree.