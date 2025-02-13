using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    /// <summary>
    /// Take a secret number
    /// Find the maximum possible secret number
    /// Start guessing 1, 2, 3, ...
    /// Until we find the secret number
    /// </summary>
    internal class AlgorithmA
    {
        private SecretNumber secretNumber;
        private int totalGuesses = 0;

        internal AlgorithmA(SecretNumber s)
        {
            this.secretNumber = s;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>(secretNumber, number of Guesses)</returns>
        internal (int, int) GuessNumber() {
            totalGuesses = 0;

            for (int i = 1; i <= secretNumber.MaxNumber(); i++)
            {
                // make a guess
                totalGuesses++;

                if (secretNumber.Guess(i) == 0)
                {
                    // we found the correct number!
                    return (i, totalGuesses);
                }
                // we did not guess correctly, keep guessing
            }

            // the secret number is not between 1 and max number (inclusive)
            // there is an error!
            throw new ApplicationException("There is an issue somewhere! Is secret number set correctly?");
        }

    }
}
