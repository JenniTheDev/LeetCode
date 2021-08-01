using System;

namespace LongestSubstringWithoutRepeating {
    internal class Program {

        private static void Main(string[] args) {
            Solution substringTest = new Solution();

            string exampleOne = "abcabcbb";
            Console.WriteLine($"This should be 3: {substringTest.LengthOfLongestSubstring(exampleOne)}"); // works

            string exampleTwo = "bbbbb";
            Console.WriteLine($"This should be 1: {substringTest.LengthOfLongestSubstring(exampleTwo)}"); // works

            string exampleThree = "pwwkew";
            Console.WriteLine($"This should be 3: {substringTest.LengthOfLongestSubstring(exampleThree)}"); // works

            string exampleFour = "";
            Console.WriteLine($"This should be 0: {substringTest.LengthOfLongestSubstring(exampleFour)}"); // works

            string exampleFive = " ";
            Console.WriteLine($"This should be 1: {substringTest.LengthOfLongestSubstring(exampleFive)}");

            string exampleSix = "au";
            Console.WriteLine($"This should be 2: {substringTest.LengthOfLongestSubstring(exampleSix)}");

            string exampleSeven = "aab";
            Console.WriteLine($"This should be 2: {substringTest.LengthOfLongestSubstring(exampleSeven)}");
        }
    }
}