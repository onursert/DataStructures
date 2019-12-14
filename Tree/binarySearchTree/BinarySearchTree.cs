using System;
using System.Collections.Generic;

namespace binarySearchTree
{
    class BinarySearchTree
    {
        Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public BinarySearchTree(int inital)
        {
            root = new Node(inital);
        }

        public bool isEmpty()
        {
            return root == null;
        }

        public Node Search(int value)
        {
            Node pointer = root;
            while (value != pointer.value)
            {
                if (value < pointer.value)
                {
                    pointer = pointer.left;
                }
                else if (value > pointer.value)
                {
                    pointer = pointer.right;
                }

                //If we search a number that is not in the tree.
                if (pointer == null)
                {
                    break;
                }
            }
            return pointer;
        }

        //Iterative Way
        public Node FindMax(int startingRoot)
        {
            //We want to find what is the node that has max value of the tree. That tree's root value is startingRoot.
            //For this we have to find the node in the tree. That node's value is startingRoot.
            Node pointer = Search(startingRoot);

            if (pointer == null)
            {
                Console.WriteLine("There is no element in this tree such as " + startingRoot + ".");
                return null;
            }

            //pointer is equal to the node that we have been searching.
            //Now we can find max value of the tree. That tree's root value is startingRoot.
            while (pointer.right != null)
            {
                pointer = pointer.right;
            }

            //pointer is equal to the node that has max value of the tree.
            return pointer;
        }

        //Recursive Way
        public Node FindMin(int startingRoot)
        {
            Node pointer = Search(startingRoot);

            if (pointer == null)
            {
                Console.WriteLine("There is no element in this tree such as " + startingRoot + ".");
                return null;
            }

            /*
            while (pointer.left != null)
            {
                pointer = pointer.left;
            }

            return pointer;*/

            if (pointer.left != null)
            {
                return FindMin(pointer.left.value);
            }

            return pointer;
        }

        public int FindHeight(int startingRoot)
        {
            Node pointer = Search(startingRoot);

            if (pointer == null)
            {
                Console.WriteLine("There is no element in this tree such as " + startingRoot + ".");
                return 0;
            }

            int left = 0;
            int right = 0;
            if (pointer.left != null)
            {
                left = FindHeight(pointer.left.value);
            }
            if (pointer.right != null)
            {
                right = FindHeight(pointer.right.value);
            }
            return Math.Max(left, right) + 1;
        }

        public void Add(int value)
        {
            if (root == null)
            {
                root = new Node(value);
            }
            else
            {
                Node pointer = root;
                while (true)
                {
                    if (value < pointer.value)
                    {
                        if (pointer.left == null)
                        {
                            Node newNode = new Node(value);
                            pointer.left = newNode;
                            newNode.parent = pointer;
                            break;
                        }
                        pointer = pointer.left;
                    }
                    else if (value > pointer.value)
                    {
                        if (pointer.right == null)
                        {
                            Node newNode = new Node(value);
                            pointer.right = newNode;
                            newNode.parent = pointer;
                            break;
                        }
                        pointer = pointer.right;
                    }
                }
            }
        }

        public void Remove(int value)
        {
            //We are searching the node that we want to remove.
            Node pointer = Search(value);

            if (pointer == null)
            {
                Console.WriteLine("There is no element in this tree such as " + value + ".");
                return;
            }

            //Now pointer is equal to the node that we want to remove.
            //Now we can remove the node but we have to replace it some specific node.
            //For this, we have 3 cases.

            //Case 1 : If the node that we want to remove has no child.
            if (pointer.left == null && pointer.right == null)
            {
                //If pointer is located in parent.left , parent.left will be pointing at null.
                if (pointer.parent.left == pointer)
                {
                    pointer.parent.left = null;
                }
                //If pointer is located in parent.right , parent.right will be pointing at null.
                if (pointer.parent.right == pointer)
                {
                    pointer.parent.right = null;
                }
            }

            //Case 2 : If the node that we want to remove has 1 child.
            //The node have to be replaced by FindMax(pointer.left.value) because node has only left node.
            //And replacedNumber have to be removed from old position.
            if (pointer.left != null && pointer.right == null)
            {
                int numberForReplacing = FindMax(pointer.left.value).value;
                Remove(numberForReplacing);
                pointer.value = numberForReplacing;
            }
            //The node have to be replaced by FindMin(pointer.right.value) because node has only right node.
            //And replacedNumber have to be removed from old position.
            if (pointer.right != null && pointer.left == null)
            {
                int numberForReplacing = FindMin(pointer.right.value).value;
                Remove(numberForReplacing);
                pointer.value = numberForReplacing;
            }

            //Case 3 : If the node that we want to remove has 2 children.
            //The node have to be replaced by either FindMax(pointer.left.value) or FindMin(pointer.right.value).
            //And replacedNumber have to be removed from old position.
            if (pointer.left != null && pointer.right != null)
            {
                int numberForReplacing = FindMax(pointer.left.value).value;
                //int numberForReplacing = FindMin(pointer.right.value).value;
                Remove(numberForReplacing);
                pointer.value = numberForReplacing;
            }
        }

        public void InOrder(int startingRoot)
        {
            Node pointer = Search(startingRoot);

            if (pointer == null)
            {
                Console.WriteLine("There is no element in this tree such as " + startingRoot + ".");
                return;
            }

            if (pointer.left != null)
            {
                InOrder(pointer.left.value);
            }
            Console.WriteLine(pointer.value);
            if (pointer.right != null)
            {
                InOrder(pointer.right.value);
            }
        }

        public void PreOrder(int startingRoot)
        {
            Node pointer = Search(startingRoot);

            if (pointer == null)
            {
                Console.WriteLine("There is no element in this tree such as " + startingRoot + ".");
                return;
            }

            Console.WriteLine(pointer.value);
            if (pointer.left != null)
            {
                PreOrder(pointer.left.value);
            }
            if (pointer.right != null)
            {
                PreOrder(pointer.right.value);
            }
        }

        public void PostOrder(int startingRoot)
        {
            Node pointer = Search(startingRoot);

            if (pointer == null)
            {
                Console.WriteLine("There is no element in this tree such as " + startingRoot + ".");
                return;
            }

            if (pointer.left != null)
            {
                PostOrder(pointer.left.value);
            }
            if (pointer.right != null)
            {
                PostOrder(pointer.right.value);
            }
            Console.WriteLine(pointer.value);
        }


        public void LevelOrder(int startingRoot)
        {
            Node pointer = Search(startingRoot);

            if (pointer == null)
            {
                Console.WriteLine("There is no element in this tree such as " + startingRoot + ".");
                return;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(pointer);
            while (queue.Count != 0)
            {
                pointer = queue.Dequeue();
                Console.WriteLine(pointer.value);

                if (pointer.left != null)
                {
                    queue.Enqueue(pointer.left);
                }
                if (pointer.right != null)
                {
                    queue.Enqueue(pointer.right);
                }
            }
        }
    }
}
