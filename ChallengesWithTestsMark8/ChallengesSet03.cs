using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for(int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) { return false; }
            int total = 0;
            foreach (int integer in numbers)
            {
                if(integer % 2 != 0)
                {
                    total += integer;
                }
            }
            if (total % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;
            for (int i = 0; i < password.Length && !(hasUpper && hasLower && hasDigit); i++)
            {
                char c = password[i];
                if (!hasUpper) hasUpper = char.IsUpper(c);
                if (!hasLower) hasLower = char.IsLower(c);
                if (!hasDigit) hasDigit = char.IsDigit(c);
            }
            if (hasUpper && hasLower && hasDigit) { return true; }
            else { return false; }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0) { return 0; }
            decimal result = dividend / divisor;
            return result;
        }

        public int LastMinusFirst(int[] nums)
        {
            int result = nums[nums.Length - 1] - nums[0];
            return result;
        }

        public int[] GetOddsBelow100()
        {
            int[] answer = new int[50];
            int j = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    answer[j] = i;
                    j++;
                }
            }
            return answer;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].ToUpper();
        }
    }
}
