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

    public void PrintTree()
    {
        PrintTree(Root, 0);
    }
}