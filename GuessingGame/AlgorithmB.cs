using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class AlgorithmB
    {
        private SecretNumber secretNumber;
        private int totalGuesses = 0;

        internal AlgorithmB(SecretNumber s)
        {
            this.secretNumber = s;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>(secretNumber, number of Guesses)</returns>
        internal (int, int) GuessNumber()
        {
            totalGuesses = 0;

            // min and max will keep track of the range where the secret number can be
            int min = 1;
            int max = secretNumber.MaxNumber();

            int nextGuess = (min + max) / 2;

            while (true)
            {
                // problem encountered
                if (min > max) break;

                totalGuesses++;
                int guessResult = secretNumber.Guess(nextGuess);

                if (guessResult == 0)
                {   // you have guessed correctly!
                    return (nextGuess, totalGuesses);
                }
                else
                {   // guess is incorrect. Is the secret number larger or smaller?
                    if (guessResult > 0)
                    {
                        // your guess is too large
                        max = nextGuess - 1;
                    }
                    else
                    {
                        // guess is too small
                        // guessResult < 0
                        min = nextGuess + 1;
                    }
                }

                nextGuess = (min + max) / 2;
            }
            // the secret number is not between 1 and max number (inclusive)
            // there is an error!
            throw new ApplicationException("There is an issue somewhere! Is secret number set correctly?");
        }
    }
}
