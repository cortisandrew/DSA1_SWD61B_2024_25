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


/// <remarks>Method only works for positive values of n</remarks>
int Factorial(int n)
{
    // Stopping condition: immediately return the answer for a simple case
    if (n == 0 || n == 1)
    {
        return 1;
    }

    // A recursive method will make a recursive call
    // i.e. it will call itself (possibly multiple times) with a "simpler" parameter (i.e. less time until we hit the stopping condition)
    int factorial_n_minus_1 = Factorial(n - 1);
    // factorial_n_minus_1 = Factorial(n - 1);

    return n * factorial_n_minus_1; // often you also have some additional work
}