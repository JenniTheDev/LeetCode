using System;
using System.Collections.Generic;

namespace Top_K_Frequent_Words {
    internal class Program {

        private static void Main(string[] args) {
            Solution solution = new Solution();
            string[] exOne = { "i", "love", "leetcode", "i", "love", "coding" };
            int exOneK = 2;
            IList<string> exOneList = solution.TopKFrequent(exOne, exOneK);
            Console.WriteLine($"Answer one is:");
            foreach (var word in exOneList) {
                Console.WriteLine($"{word}");
            }

            string[] exTwo = { "the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is" };
            int exTwoK = 4;
            IList<string> exTwoList = solution.TopKFrequent(exTwo, exTwoK);
            Console.WriteLine($"Answer two is:");
            foreach (var word in exTwoList) {
                Console.WriteLine($"{word}");
            }
        }
    }
}