using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int newNumber = startNumber + 1; 
            while (newNumber % n != 0)
            {
                newNumber++;
            }
            return newNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(int i = 0; i < businesses.Length; i++)
            {
                if(businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) { return false; }
            if (numbers.Length == 1) { return true; }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1) { return true; }
                else if (numbers[i] > numbers[i + 1]) { return false; }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null) { return 0; }
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1) { return result; }
                else if (numbers[i] % 2 == 0)
                {
                    result += numbers[i + 1];
                }
            }
            return result;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string result = "";
            if (words == null) { return ""; }
            if (words.Length == 0) { return ""; }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == " " || words[i] == "" || words[i] == "  ") { result += ""; }
                else
                {
                    result += words[i].Replace(" ", "");
                    if (i == words.Length - 1) { result += "."; }
                    else { result += " "; }
                }
            }
            return result;

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var myList = new List<double>();
            var emptyArr = new double[] { };
            if (elements == null) { return emptyArr; }
            if (elements.Count < 4) { return emptyArr; }
            int i = 1;
            foreach (double nums in elements)
            {
                if (i % 4 == 0)
                {
                    myList.Add(nums);
                }
                i++; 
            }
            double[] result = myList.ToArray();
            return result;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums.Length < 2) { return false; }
            for (int i = 0; i < nums.Length; i++)
            {
                int j = i + 1;
                while (j < nums.Length) 
                {
                    if (nums[i] + nums[j] == targetNumber) { return true; }
                    j++;
                }
            }
            return false;
        }
    }
}
