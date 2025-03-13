// See https://aka.ms/new-console-template for more information
using ADTs_and_DSs.ABV;
using ADTs_and_DSs.Interfaces;
using ADTs_and_DSs.LinkedListFolder;
using ADTs_and_DSs.QueueUsingLinkedList;
using ADTs_and_DSs.StackUsingABV;
using System.Diagnostics;


// ABV_Program();

// StackTest();

// TestingLinkedList();

// Start Empirical Analysis for Queue

// Create a list of problem sizes to measure (this is the x-axis)
// Remember in many algorithms, the problem size affects the time
// You are interested in how the time reacts when the problem size increases
int[] problemSizes = new int[] { 10, 20, 100, 200, 10000, 100000 };

// The number of measurements for each problem size
int repetitions = 20;

Stopwatch stopwatch = new Stopwatch();

// Setup and run the problem once, without keeping its timing
Queue_LinkedList<int> queue = new Queue_LinkedList<int>();
for (int i = 0; i < 1000; i++)
{
    stopwatch.Start();
    queue.Enqueue(i);
    stopwatch.Stop();
}
// The above will allow the program to run once, and the very large time at the beginning will not be so large

Console.WriteLine("n, Time in ticks");
foreach(int problemSize in problemSizes)
{
    stopwatch.Reset(); // reset the stopwatch to 0 time

    // repeat a number of repetitions
    for (int j = 0; j < repetitions; j++)
    {
        // setup the scenario

        // example, let's create a queue with problemSize number of elements (problemSize is also called n sometimes)
        queue = new Queue_LinkedList<int>();
        for (int i = 0; i < problemSize; i++)
        {
            queue.Enqueue(i);
        }

        // setup is complete


        // this is the algorithm that I want to measure its speed
        stopwatch.Start();
        queue.Enqueue(0);
        stopwatch.Stop();
    }

    // return the average time over all the repetitions
    Console.WriteLine($"{problemSize}, {stopwatch.ElapsedTicks/(double)repetitions}");
}





ArrayBasedVector<int> CreateArrayBasedVectorOfCount(int count)
{
    ArrayBasedVector<int> outputABV = new ArrayBasedVector<int>();

    // since I want the outputABV to contain "count" elements, we have to add them one by one
    for (int i = 0; i < count; i++)
    {
        // always place in the last location
        outputABV.InsertElementAtRank(i, 0);
    }

    return outputABV;
}

void ABV_Program()
{
    ArrayBasedVector<string> arrayBasedVector = new ArrayBasedVector<string>(new[] { "Mavis", "Francis", "Dylan", "Eve" });

    Console.WriteLine(arrayBasedVector);

    Console.WriteLine(arrayBasedVector.GetElementAtRank(2));

    arrayBasedVector.InsertElementAtRank(1, "Charles");

    Console.WriteLine(arrayBasedVector);

    Console.WriteLine($"We have just replaced {arrayBasedVector.ReplaceElementAtRank(4, "Alice")}");

    Console.WriteLine(arrayBasedVector);

    arrayBasedVector.RemoveElementAtRank(2);

    Console.WriteLine(arrayBasedVector);

    arrayBasedVector.ReplaceElementAtRank(3, "Bob");

    Console.WriteLine(arrayBasedVector);
    Console.WriteLine(arrayBasedVector);


    Console.Clear();

    /*
    int time = arrayBasedVector.InsertElementAtRankTwo(0, "A");
    Console.WriteLine($"Inserting the value A at position 0, in an ABV of count {arrayBasedVector.Count()} took {time} time");

    time = arrayBasedVector.InsertElementAtRankTwo(arrayBasedVector.Count(), "B");
    Console.WriteLine($"Inserting the value B at the last position, in an ABV of count {arrayBasedVector.Count()} took {time} time");
    

    Console.Clear();

    List<int> problemSizes = new List<int>() { 100, 200, 400, 800 };

    foreach (int problemSize in problemSizes)
    {
        ArrayBasedVector<int> intArrayBasedVector = CreateArrayBasedVectorOfCount(problemSize);
        int countBeforeInsert = intArrayBasedVector.Count();
        time = intArrayBasedVector.InsertElementAtRankTwo(problemSize, 1); // append
                                                                           // Console.WriteLine($"The time to append a new element in an ABV of count {countBeforeInsert} is {time} time");
        Console.WriteLine($"{countBeforeInsert}, {time}");
    }

    Console.WriteLine();

    foreach (int problemSize in problemSizes)
    {
        ArrayBasedVector<int> intArrayBasedVector = CreateArrayBasedVectorOfCount(problemSize);
        int countBeforeInsert = intArrayBasedVector.Count();
        time = intArrayBasedVector.InsertElementAtRankTwo(0, 1); // insert at first location
                                                                 // Console.WriteLine($"The time to prepend a new element in an ABV of count {countBeforeInsert} is {time} time");
        Console.WriteLine($"{countBeforeInsert}, {time}");
    }
    */
}

static void StackTest()
{
    Stack_ABV<char> stack = new Stack_ABV<char>();

    string reversedString = "olleh";

    for (int i = 0; i < reversedString.Length; i++)
    {
        stack.Push(reversedString[i]);
    }

    while (!stack.IsEmpty())
    {
        Console.Write(stack.Pop());
    }
    Console.WriteLine();

    Stopwatch sw = new Stopwatch();

    for (int i = 0; i < 10000000; i++)
    {
        sw.Start();
        stack.Push('a');
        sw.Stop();
    }

    Console.WriteLine($"The total time for pushing 10000000 elements is {sw.ElapsedMilliseconds}ms ");
}

static void TestingLinkedList()
{
    SinglyLinkedList<string> singlyLinkedList = new SinglyLinkedList<string>();
    singlyLinkedList.InsertFirst("C");
    singlyLinkedList.InsertFirst("B");
    singlyLinkedList.InsertFirst("A");

    //SinglyLinkedListNode<string> cursor = singlyLinkedList.Head;

    //while (cursor != null)
    //{
    //    Console.WriteLine(cursor.Element);
    //    cursor = cursor.Next; // move forward one step
    //}

    Console.WriteLine(singlyLinkedList);


    Queue_LinkedList<int> queue = new Queue_LinkedList<int>();

    int elementsToEnqueue = 100000;

    Stopwatch sw = new Stopwatch();
    sw.Start();
    for (int i = 0; i < elementsToEnqueue; i++)
    {
        queue.Enqueue(i);
    }

    while (queue.Count > 0)
    {
        queue.Dequeue();
    }
    sw.Stop();
    Console.WriteLine(sw.ElapsedMilliseconds);
    // About 20 seconds with inefficient implementation!

    // Exercise: Implement the Stack using a linked list
}