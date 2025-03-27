// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] ns = new int[] { 2, 4, 8, 16, 32, 64 };


foreach (int n in ns)
{
    int time = H(n);

    Console.WriteLine($"{n}, {time}");
}
int H(int n)
{
    int sum = 0;

    int i = n;

    while (i > 1)
    {
        sum++;
        i = i / 2;
    }

    return sum;
}