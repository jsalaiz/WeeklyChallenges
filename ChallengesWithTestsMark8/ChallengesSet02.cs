using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
            string uppercaseAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return (lowercaseAlphabet.Contains(c) || uppercaseAlphabet.Contains(c));
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0);
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0 && num != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null) { return 0; }
            else if (!numbers.Any()) { return 0; }
            else { return numbers.Min() + numbers.Max(); }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length < str2.Length) ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            var result = 0;
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    result += numbers[i];
                }
                return result;
            }
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int result = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result += numbers[i];
                }
            }

            return result;
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else
            {
                return (numbers.Sum() % 2 != 0);
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return (number <= 0) ? 0 : number / 2;
        }
    }
}
