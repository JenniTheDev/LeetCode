using System;

namespace Palindrome_Number {
    internal class Program {

        private static void Main(string[] args) {
            Solution solution = new Solution();

            int exOne = 121;
            Console.WriteLine($"Should be true: {solution.IsPalindrome(exOne)}");

            int exTwo = -121;
            Console.WriteLine($"Should be false: {solution.IsPalindrome(exTwo)}");

            int exThree = 10;
            Console.WriteLine($"Should be false: {solution.IsPalindrome(exThree)}");

            int exFour = -101;
            Console.WriteLine($"Should be false: {solution.IsPalindrome(exFour)}");
        }
    }
}