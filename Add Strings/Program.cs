using System;

namespace Add_Strings {
    internal class Program {

        private static void Main(string[] args) {
            Solution solution = new Solution();

            string testOne = "11";
            string testTwo = "123";
            Console.WriteLine($"Sound equal 134: {solution.AddStrings(testOne, testTwo)}");
        }
    }
}