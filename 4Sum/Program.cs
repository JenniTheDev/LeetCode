using System;
// https://leetcode.com/explore/featured/card/july-leetcoding-challenge-2021/610/week-3-july-15th-july-21st/3816/
namespace _4Sum {
    class Program {
        static void Main(string[] args) {
            int[] exampleOne = new int[] { 1, 0, -1, 0, -2, 2 };
            int targetOne = 0;
            Console.WriteLine("Example One "+ new Solution().FourSum(exampleOne, targetOne));

            int[] exampleTwo = new int[] { 2, 2, 2, 2, 2 };
            int targetTwo = 8;
            Console.WriteLine("Example One " + new Solution().FourSum(exampleTwo, targetTwo));
        }
    }
}
