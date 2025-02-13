using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class SecretNumber
    {
        int secretNumber;
        int maxNumber;

        /// <summary>
        /// If max Number is 100, secret number is between 1 and 100 (both inclusive)
        /// </summary>
        /// <param name="maxNumber">Defaults to 100</param>
        internal SecretNumber(int maxNumber = 100, int? setSecretNumber = null)
        {
            if (maxNumber < 1)
            {
                throw new ArgumentException();
            }

            if (setSecretNumber == null)
            {
                // secret number not set by user, this means  that we select the number at random
                Random r = new Random();
                secretNumber = r.Next(1, maxNumber + 1);
            }
            else
            {
                // secret number is chosen by the user
                // validate that secret number is between 1 and max number (inclusive)
                secretNumber = setSecretNumber.Value;
            }
            this.maxNumber = maxNumber;

#if DEBUG
            Debug.WriteLine($"The secret number chosen is {secretNumber}");
#endif
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="guess"></param>
        /// <returns>0 if you guessed correctly
        /// 1 if guess is larger than secret number
        /// -1 if guess is smaller than secret number</returns>
        internal int Guess(int guess)
        {
#if DEBUG
            Debug.WriteLine($"We have guessed the value {guess}");
#endif
            return guess.CompareTo(secretNumber);
        }

        /// <summary>
        /// What is the maximum number to guess?
        /// </summary>
        /// <returns></returns>
        internal int MaxNumber() { return maxNumber; }
    }
}
