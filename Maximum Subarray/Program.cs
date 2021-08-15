using System;

namespace Maximum_Subarray {
    internal class Program {

        private static void Main(string[] args) {
            Solution solution = new Solution();
            int[] testArrayOne = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.WriteLine($"Max subarray should be 6: {solution.MaxSubArray(testArrayOne)}");

            int[] testArrayTwo = { 1 };
            Console.WriteLine($"Max subarray should be 1: {solution.MaxSubArray(testArrayTwo)}");

            int[] testArrayThree = { 5, 4, -1, 7, 8 };
            Console.WriteLine($"Max subarray should be 23: {solution.MaxSubArray(testArrayThree)}");
        }
    }
}