// See https://aka.ms/new-console-template for more information
using TreeDataStructures;

Console.WriteLine("Hello, World!");

BinarySearchTree<string> tree = new BinarySearchTree<string>();

tree.Add(7, "Seven");
tree.Add(3, "Three");
tree.Add(10, "Ten");
tree.Add(5, "Five");
tree.Add(20, "Twenty");

tree.Add(13, "Thirteen");

Console.WriteLine("Program has ended!");