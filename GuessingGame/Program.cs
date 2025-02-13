using GuessingGame;
using System.Diagnostics;

int runs = 10; // the number of times the game is played when we want to take an average

// 2 ^ 30
int maxSecretNumber = 1024 * 1024 * 1024; // this is also the problem size, n (i.e. in this case the possible secret numbers to guess)

SecretNumber secretNumber = new SecretNumber(maxSecretNumber);
AlgorithmB algorithmB = new AlgorithmB(secretNumber);
(int, int) result = algorithmB.GuessNumber();

Console.WriteLine($"The secret number is {result.Item1} and we required {result.Item2} guesses");

//int a = 900;
//int b = 1000;

//Console.WriteLine($"{a / b}");
//Console.WriteLine($"{a/(double)b}");

//// TimeMeanGuessesAlgorithmA(runs, maxSecretNumber);

//SecretNumber secretNumber = new SecretNumber(maxSecretNumber, 3);
//AlgorithmA algorithmA = new AlgorithmA(secretNumber);
//(int, int) result = algorithmA.GuessNumber();


static void TimeMeanGuessesAlgorithmA(int runs, int maxSecretNumber)
{
    List<int> guessesHistory = new List<int>(); // store the number of guesses required for each run
    // Stopwatch stopwatch = new Stopwatch();


    for (int i = 0; i < runs; i++)
    {
        SecretNumber s = new SecretNumber(maxSecretNumber);
        AlgorithmA algorithmA = new AlgorithmA(s);

        (int, int) result = algorithmA.GuessNumber();
        guessesHistory.Add(result.Item2);
        // Console.WriteLine($"The secret number is {result.Item1} and we required {result.Item2} guesses");
    }

    Console.WriteLine($"The mean number of guess required is {guessesHistory.Average()}");
}