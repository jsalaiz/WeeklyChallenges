using System;
using System.Collections.Generic;
using System.Linq;

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
            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            var result = -1;
            var freq = new Dictionary<char, int>();
            if (str.Length < 1) { return -1; }
            for (int i = 0; i < 25; i++)
            {
                int j = 0;
                for (int g = 0; g < str.Length; g++ )
                {
                    if (str[g] == alphabet[i]) { j++; }
                }
                freq.Add(alphabet[i], j);
            }
            if (freq.ContainsValue(1))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if(freq(str[i]) == 1) { return i; }
                }
            }
            
            return result;
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
