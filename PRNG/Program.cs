// See https://aka.ms/new-console-template for more information
using PRNG;

Console.WriteLine("Hello, World!");

LCG myLCG = new LCG();

for (int i = 0; i < 23; i++)
{
   Console.WriteLine(myLCG.Next(1,7));
}

int[] sorted = new int[] { 1, 2, 3, 4, 5, 6 };
FYShuffle fy = new FYShuffle();
fy.Shuffle(sorted);

Console.WriteLine(String.Join(", ", sorted));

