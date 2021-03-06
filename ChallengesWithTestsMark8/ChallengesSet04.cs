using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result += numbers[i];
                }
                else if (numbers[i] % 2 != 0)
                {
                    result -= numbers[i];
                }
            }
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int[] array = new int[] { str1.Length, str2.Length, str3.Length, str4.Length };
            int result = array[0];
            for (int i = 0; i < 4; i++)
            {
                if (array[i] < result) { result = array[i]; }
            }
            return result;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] array = new int[] { number1, number2, number3, number4 };
            int result = array[0];
            for (int i = 0; i < 4; i++)
            {
                if (array[i] < result) { result = array[i]; }
            }
            return result;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if ((sideLength1 == 0) || (sideLength2 == 0) || (sideLength3 == 0)) { return false; }
            else if ((sideLength1 < 0) || (sideLength2 < 0) || (sideLength3 < 0)) { return false; }
            else if (sideLength1 + sideLength2 <= sideLength3) { return false; }
            else if (sideLength1 + sideLength3 <= sideLength2) { return false; }
            else if (sideLength3 + sideLength2 <= sideLength1) { return false; }
            else { return true; }
        }

        public bool IsStringANumber(string input)
        {
            if (input == null) { return false; }
            string b = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) || input.Contains("-") || input.Contains("."))
                { 
                    b += input[i];
                }
                else { return false; }
            }

            if (b.Length > 0)
            {
                return true;
            }
            else {return false; }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int i = 0;
            foreach (object element in objs)
            {
                if (element == null)
                {
                    i++;
                }
            }
            if (i > objs.Length / 2) { return true; }
            else { return false; }
        }

        public double AverageEvens(int[] numbers)
        {
            int i = 0;
            double result = 0;

            if (numbers == null) { return 0; }

            foreach (int integer in numbers)
            {
                if (integer % 2 == 0)
                {
                    i++;
                    result += integer;
                }
            }
            if (i > 0) { return (result / i); }
            else { return 0; }
        }

        public int Factorial(int number)
        {
            int result = 1;
            if (number < 0) { throw new ArgumentOutOfRangeException(); }
            if (number <= 2 && number > 0) { return number; }
            else
            {
                for (int i = 1; i < number + 1; i++)
                {
                    result *= i;
                }
            }
            return result;
        }
    }
}
