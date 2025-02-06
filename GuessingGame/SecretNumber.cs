using System;
using System.Collections.Generic;
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
        /// <param name="maxNumber"></param>
        internal SecretNumber(int maxNumber)
        {
            Random r = new Random();
            secretNumber = r.Next(1, maxNumber + 1);
            this.maxNumber = maxNumber;
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
            return guess.CompareTo(secretNumber);
        }

        /// <summary>
        /// What is the maximum number to guess?
        /// </summary>
        /// <returns></returns>
        internal int MaxNumber() { return maxNumber; }
    }
}
