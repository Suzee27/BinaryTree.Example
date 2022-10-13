// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string value;

public class Tree
{
    public string value;
    private List<string> children;
    private int childrenCount;
    public string root { get; set; }
    public string parent { get; set; }
    public int ChildrenCount
    {
        get { return children.Count; }
    }

    public List<string> Children
    {
        get { return children; }
        set { children = value; }
    }
    
    public void Insert(string value,  NodeChild childPosition)
    {
        if (root == null) root = value;
        else
        {
            if (childPosition == NodeChild.left) Node.leftNode = value;
            else Node.rightNode = value;
            children.Add(value); 
            parent = value;
        }
            
    }
    public void DeleteNode()
    {

    }
}

public static class Node
{
    internal static string rightNode;

    public static string leftNode { get; set; }
}

public enum NodeChild
{
    left, right,
}
