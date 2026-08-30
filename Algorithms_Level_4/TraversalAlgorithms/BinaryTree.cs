using System.Numerics;
using Microsoft.Win32.SafeHandles;

namespace Algorithms_Level_4.TraversalAlgorithms;

public class BinaryTree<T>
{
    public BinaryTreeNode<T>? Root { get; set; }

    public BinaryTree()
    {
        Root = null;
    }


    public void Insert(T value)
    {
        var newNode = new BinaryTreeNode<T>(value);
        if (Root == null)
        {
            Root = newNode;
            return;
        }


        Queue<BinaryTreeNode<T>> queue = new();

        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            if (current.Left == null)
            {
                current.Left = newNode;
                break;
            }
            else
            {
                queue.Enqueue(current.Left);
            }


            if (current.Right == null)
            {
                current.Right = newNode;
                break;
            }
            else
            {
                queue.Enqueue(current.Right);
            }
        }
    }

    public void PreOrderTraversal()
    {
        PreOrderTraversal(Root);
    }

    private void PreOrderTraversal(BinaryTreeNode<T>? node)
    {
        if (node != null)
        {
            Console.Write(node.Value + " ");
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }
    }


    public void InOrderTraversal()
    {
        InOrderTraversal(Root);
        Console.WriteLine();
    }

    private void InOrderTraversal(BinaryTreeNode<T>? node)
    {
        if (node != null)
        {
            InOrderTraversal(node.Left);
            Console.Write(node.Value + " ");
            InOrderTraversal(node.Right);
        }
    }

    public void PostOrderTraversal()
    {
        PostOrderTraversal(Root);
        Console.WriteLine();
    }

    private void PostOrderTraversal(BinaryTreeNode<T>? node)
    {
        if (node != null)
        {
            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.Write(node.Value + " ");
        }
    }


    private void PrintTree(BinaryTreeNode<T>? root, int space)
    {
        int Count = 10;
        if (root == null)
            return;

        space += Count;
        PrintTree(root.Right, space);

        Console.WriteLine();

        for (int i = Count; i < space; i++)
            Console.Write(" ");

        Console.WriteLine(root.Value);

        PrintTree(root.Left, space);
    }

    public void LevelOrderTraversal()
    {
        BFS(Root);
        Console.WriteLine();
    }

    private void BFS<T>(BinaryTreeNode<T>? node)
    {
        if (node == null)
        {
            return;
        }


        Queue<BinaryTreeNode<T>> queue = new();
        queue.Enqueue(node);


        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            Console.Write(current.Value + " ");

            if (current.Left != null)
                queue.Enqueue(current.Left);

            if (current.Right != null)
                queue.Enqueue(current.Right);
        }
    }

    public void BinarySearchTree(T value)
    {
        var newNode = new BinaryTreeNode<T>(value);
        if (Root == null)
        {
            Root = newNode;
            return;
        }

        int comparison = Comparer<T>.Default.Compare(Root.Value, value);

        BinarySearchTree(newNode, comparison > 0 ? Root.Right : Root.Left);
    }

    private void BinarySearchTree(BinaryTreeNode<T> newNode, BinaryTreeNode<T> InsertionHalfParent)
    {
        if (InsertionHalfParent == null)
        {
            InsertionHalfParent = newNode;
            return;
        }

        var comparison = Comparer<T>.Default.Compare(InsertionHalfParent.Value, newNode.Value);
        BinarySearchTree(newNode, comparison > 0 ? InsertionHalfParent.Right : InsertionHalfParent.Left);
    }

    public void BinarySearchTreeWithWhileLoop(T value)
    {

        var newNode = new BinaryTreeNode<T>(value);
        if (Root is null)
        {
            Root = newNode;
            return;
        }


        var queue = new Queue<BinaryTreeNode<T>>();
        queue.Enqueue(Root);
        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            int comparison = Comparer<T>.Default.Compare(current.Value, newNode.Value);

            if (comparison > 0)
            {
                if (current.Right == null)
                {
                    current.Right = newNode;
                }
                else
                {
                    queue.Enqueue(current.Right);
                }
                
            }
            else
            {
                if (current.Left == null)
                {
                    current.Left = newNode;
                }
                else
                {
                    queue.Enqueue(current.Left);
                }
            }
        }

    }


    public void PrintTree()
    {
        PrintTree(Root, 0);
    }
}