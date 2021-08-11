using System;

namespace Valid_Palindrome {
    internal class Program {

        private static void Main(string[] args) {
            Solution solution = new Solution();
            Console.WriteLine($"This should be true: {solution.IsPalindrome("A man, a plan, a canal: Panama")}");

            Console.WriteLine($"This should be false: {solution.IsPalindrome("race a car")}");

            Console.WriteLine($"This should be false: {solution.IsPalindrome("0P")}");

            Console.WriteLine($"This should be true: {solution.IsPalindrome("a.")}");

            Console.WriteLine($"This should be true: {solution.IsPalindrome("Marge, let's \"[went].\" I await {news} telegram.")}");

            Console.WriteLine($"This should be true: {solution.IsPalindrome("Live on evasions ? No, I save no evil.")}");
        }
    }
}