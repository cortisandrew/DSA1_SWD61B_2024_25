// See https://aka.ms/new-console-template for more information
using ADTs_and_DSs.ABV;
using ADTs_and_DSs.Interfaces;

ArrayBasedVector<string> arrayBasedVector = new ArrayBasedVector<string>(new [] {"Mavis", "Francis", "Dylan", "Eve"});

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