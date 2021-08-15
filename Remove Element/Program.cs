using System;

namespace Remove_Element {
    internal class Program {

        private static void Main(string[] args) {
            Solution solution = new Solution();
            //int[] testArrayOne = { 3, 2, 2, 3 };
            //int testValOne = 3;
            //int testAnswerOne = solution.RemoveElement(testArrayOne, testValOne);
            //Console.WriteLine($"Test One should be 2: {testAnswerOne}");

            int[] testArrayTwo = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int testValTwo = 2;
            int testAnswerTwo = solution.RemoveElement(testArrayTwo, testValTwo);
            Console.WriteLine($"Test Two should be 5: {testAnswerTwo}");
        }
    }
}