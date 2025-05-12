using SortingAlgorithms;

int r = 100;
int n = 10000;
SortingAlgorithmClass s = new SortingAlgorithmClass();

/*
int[] array = new int[] { 8, 4, 7, 6, 2, 5 };

Console.WriteLine(String.Join(", ", s.MergeSort(array)));
*/

Random random = new Random();

int[] array = new int[n];
int[] arrayCopy = new int[n];

for (int j = 0; j < r; j++)
{
    for (int i = 0; i < n; i++)
    {
        array[i] = random.Next(2 * n);
    }

    array.CopyTo(arrayCopy, 0);

    // int[] heapSortedArray = s.HeapSort(array);
    s.QuickSort(array);
    Array.Sort(arrayCopy);

    if (array.SequenceEqual(arrayCopy))
    {
        Console.WriteLine(
            "Arrays are equal");
    }
    else
    {
        Console.WriteLine("Arrays are not equal");
    }
}