// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Tree BinaryTree = new Tree();
BinaryTree.Insert("                 Scrum Team");
BinaryTree.Insert("Product Owner", NodeChild.left);
Console.Write("                        ");
BinaryTree.Insert("Scrum Master", NodeChild.right);
Console.WriteLine();
Console.WriteLine();
BinaryTree.Insert("                             Developer 1", NodeChild.left);
Console.Write("         ");
BinaryTree.Insert("Developer 2", NodeChild.right);

Console.WriteLine();

Console.WriteLine(BinaryTree.DeleteNode("Developer 2"));
Console.WriteLine("Total number of Children in the tree: " + BinaryTree.ChildrenCount);

BinaryTree.DeleteTree();
Console.WriteLine("deleted");
