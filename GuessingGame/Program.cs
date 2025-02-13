using GuessingGame;
using System.Diagnostics;

int runs = 10; // the number of times the game is played when we want to take an average

int maxSecretNumber = 100; // this is also the problem size, n (i.e. in this case the possible secret numbers to guess)

// TimeMeanGuessesAlgorithmA(runs, maxSecretNumber);

SecretNumber secretNumber = new SecretNumber(maxSecretNumber, 3);
AlgorithmA algorithmA = new AlgorithmA(secretNumber);
(int, int) result = algorithmA.GuessNumber();

Console.WriteLine($"The secret number is {result.Item1} and we required {result.Item2} guesses");

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