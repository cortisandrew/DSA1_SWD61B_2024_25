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


