namespace Algorithms_Level_4.TraversalAlgorithms;

public class BinarySearchTree<T> where T : IComparable<T>
{
    public BinaryTreeNode<T> Root { get; set; }

    public BinarySearchTree()
    {
        Root = null;
    }

    public void Insert(T value)
    {
        Root = Insert(Root, value);
    }

    private BinaryTreeNode<T> Insert(BinaryTreeNode<T> node, T value)
    {
        if (node == null)
        {
            return new BinaryTreeNode<T>(value);
        }
        else if (value.CompareTo(node.Value) < 0)
        {
            node.Left = Insert(node.Left,value);
        }
        else if (value.CompareTo(node.Value) > 0)
        {
            node.Right = Insert(node.Right,value);
        }

        return node;
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

    private void BFS<T>(BinaryTreeNode<T>? node) where T : IComparable<T>
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
    

    public void PrintTree()
    {
        PrintTree(Root, 0);
    }
}