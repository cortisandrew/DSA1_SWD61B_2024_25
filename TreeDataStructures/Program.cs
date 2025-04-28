// See https://aka.ms/new-console-template for more information
using TreeDataStructures;

Console.WriteLine("Hello, World!");
/*
BinarySearchTree<string> tree = new BinarySearchTree<string>();

tree.Add(7, "Seven");
tree.Add(3, "Three");
tree.Add(10, "Ten");
tree.Add(5, "Five");
tree.Add(20, "Twenty");

tree.Add(13, "Thirteen");
*/

int count = 20;

Random rnd = new Random();
HashSet<int> keys = new HashSet<int>();
BinaryMinHeap heap = new BinaryMinHeap();

for (int i = 0; i < count; i++)
{
    bool repeat = true;
    do
    {
        int newKey = rnd.Next(count * 2);

        if (!keys.Contains(newKey))
        {
            keys.Add(newKey);
            heap.Add(newKey);
            repeat = false;
        }
    } while (repeat);
}

/*
heap.Add(2);
heap.Add(9);
heap.Add(7);
heap.Add(14);
heap.Add(18);
heap.Add(8);
heap.Add(1);
*/

Console.WriteLine(heap.RemoveMin());


Console.WriteLine(heap);





Console.WriteLine("Program has ended!");
