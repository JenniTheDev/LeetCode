using System;

namespace Two_Sum {
    internal class Program {

        private static void Main(string[] args) {
            Solution solution = new Solution();

            int[] exOneNums = { 2, 7, 11, 15 };
            int exOneTarget = 9;
            int[] answerOne = solution.TwoSum(exOneNums, exOneTarget);
            Console.WriteLine($"Test one should be 0, 1: {answerOne[0]} {answerOne[1]}");
        }
    }
}