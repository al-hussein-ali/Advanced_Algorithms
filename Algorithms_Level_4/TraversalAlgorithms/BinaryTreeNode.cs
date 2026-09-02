namespace Algorithms_Level_4.TraversalAlgorithms;

public class BinaryTreeNode<T> where T : IComparable<T>
{
    public T Value { get; set; }
    public BinaryTreeNode<T>? Left { get; set; }
    public BinaryTreeNode<T>? Right { get; set; }


    public BinaryTreeNode(T value)
    {
        this.Value = value;
        this.Left = null;
        this.Right = null;
        
    }
}