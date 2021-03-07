using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) { return false; }
            if (ignoreCase == false)
            {
                foreach (string element in words)
                {
                    if (element == null) { continue; }
                    else if (element == word) { return true; }
                }
            }
            else if (ignoreCase == true)
            {
                foreach (string element in words)
                {
                    if (element == null) { continue; }
                    else if (element.ToLower() == word.ToLower()) { return true; }
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) { return false; }
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0) { return false; }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}
