using System;

namespace _4Sum {
    internal class Program {

        private static void Main(string[] args) {
            int[] exampleOne = new int[] { 1, 0, -1, 0, -2, 2 };
            int targetOne = 0;
            Console.WriteLine("Example One " + new Solution().FourSum(exampleOne, targetOne));

            int[] exampleTwo = new int[] { 2, 2, 2, 2, 2 };
            int targetTwo = 8;
            Console.WriteLine("Example One " + new Solution().FourSum(exampleTwo, targetTwo));
        }
    }
}