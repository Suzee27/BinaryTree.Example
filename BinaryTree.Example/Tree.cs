// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

public class Tree
{
    public Tree()
    {
         children = new List<string>();
    }

    public string root { get; set; }
    public string parent { get; set; }

    public int ChildNumber { get; set; }

    private int childrenCount = new int();
    public int ChildrenCount
    {
        get {return children.Count; }
    }

    private List<string> children;
    public List<string> Children
    {
        get { return children; }
        set { children = value; }
    }
    
    public void Insert(string value, [Optional] NodeChild childPosition)
    {
        if (root == null)
        {
            root = value;
            Console.WriteLine(value);
        }
        else
        {
            if (childPosition == NodeChild.left) Node.leftNode = value;
            else Node.rightNode = value;
            children.Add(value);
            parent = value;
            Console.Write(value);
        }
           
    }
    public void DeleteTree()
    {
        root = null;
    }

    public void DeleteNode(string value)
    {
        if (value == null) throw new ArgumentNullException("node does not exist");
        else
        {
            children.Remove(value);
        }
        Console.WriteLine("Node succesfully deleted");
    }

}
