using System;
using System.Collections.Generic;
using System.Linq;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            // part 1
            var potentialPasswords = GetPasswords();
            Console.WriteLine("Part 1 potential passwords: " + potentialPasswords.Count);

            //part 2
            potentialPasswords = GetPasswords(2);
            Console.WriteLine("Part 2 potential passwords: " + potentialPasswords.Count);
        }

        private static List<int> GetPasswords(int maxAdjacentDigits = int.MaxValue)
        {
            var rangeMin = 134564;
            var rangeMax = 585159;

            var potentialPasswords = new List<int>();

            for (var password = rangeMin; password <= rangeMax; password++)
            {
                var passwordDigits = GetDigitList(password).ToList();
                if (DigitCount(passwordDigits) == 6 && HasAdjacentDigits(passwordDigits, maxAdjacentDigits) && DigitsAreOrderedCorrectly(passwordDigits))
                    potentialPasswords.Add(password);
            }

            return potentialPasswords;
        }

        private static bool DigitsAreOrderedCorrectly(List<int> digits)
        {
            var digitCount = digits.Count;
            for (var i = 0; i < digitCount; i++)
            {
                if (i + 1 < digitCount && digits[i] > digits[i + 1]) return false;
            }
            return true;
        }

        private static bool HasAdjacentDigits(List<int> digits, int maxAdjacentDigits = 2)
        {
            var digitCount = digits.Count;
            var adjacentCounts = new List<int>();

            for (var i = 0; i < digitCount; i++)
            {
                if (i > 0 && digits[i] == digits[i - 1]) 
                    continue;
                var j = i;
                var adjacentDigits = 1;
                while (j < digitCount - 1 && digits[j] == digits[j + 1]) 
                { 
                    adjacentDigits++; 
                    j++; 
                }
                if (adjacentDigits > 1)
                    adjacentCounts.Add(adjacentDigits);
            }
            return adjacentCounts.Any(count => count <= maxAdjacentDigits);
        }

        private static int DigitCount(List<int> digits)
        {
            return digits.Count;
        }

        private static IEnumerable<int> GetDigitList(int number)
        {
            var numberString = number.ToString();
            foreach (var digit in numberString.ToCharArray())
                yield return int.Parse(digit.ToString());
        }
    }
}
