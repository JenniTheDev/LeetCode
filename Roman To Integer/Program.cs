using System;

namespace Roman_To_Integer {
    internal class Program {

        private static void Main(string[] args) {
            Solution solution = new Solution();

            string exOne = "III";
            int answer = solution.RomanToInt(exOne);
            Console.WriteLine($"The answer should be 3: {answer}");

            string exTwo = "IV";
            answer = solution.RomanToInt(exTwo);
            Console.WriteLine($"The answer should be 4: {answer}");

            string exThree = "IX";
            answer = solution.RomanToInt(exThree);
            Console.WriteLine($"The answer should be 9: {answer}");

            string exFour = "LVIII";
            answer = solution.RomanToInt(exFour);
            Console.WriteLine($"The answer should be 58: {answer}");

            string exFive = "MCMXCIV";
            answer = solution.RomanToInt(exFive);
            Console.WriteLine($"The answer should be 1994: {answer}");
        }
    }
}