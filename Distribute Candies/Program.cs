using System;

namespace Distribute_Candies {
    internal class Program {

        private static void Main(string[] args) {
            Solution solution = new Solution();

            int[] exOne = { 1, 1, 2, 2, 3, 3 };
            Console.WriteLine($"Output should be 3: {solution.DistributeCandies(exOne)}");

            int[] exTwo = { 1, 1, 2, 3 };
            Console.WriteLine($"Output should be 2: {solution.DistributeCandies(exTwo)}");

            int[] exThree = { 6, 6, 6, 6 };
            Console.WriteLine($"Output should be 1: {solution.DistributeCandies(exThree)}");
        }
    }
}