using System;

namespace Remove_Element {
    internal class Program {

        private static void Main(string[] args) {
            Solution solution = new Solution();
            int[] testArrayOne = { 3, 2, 2, 3 };
            int testValOne = 3;
            int testAnswerOne = solution.RemoveElement(testArrayOne, testValOne);
            Console.WriteLine($"Test One should be 2: {testAnswerOne}");
        }
    }
}