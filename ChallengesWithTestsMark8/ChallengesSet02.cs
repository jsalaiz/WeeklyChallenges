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
            throw new NotImplementedException();
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
            int result = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result += numbers[i];
                }
            }
            return (numbers == null) ? 0 : result;
            
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
