using System;

namespace LeetCode {
    class Program {
        static void Main(string[] args) {
            string testOne = "egg";
            string testTwo = "add";
            Console.WriteLine($"Testing {testOne} & {testTwo}"); // true
            Console.WriteLine(new IsomorphicString().IsIsomorphic(testOne, testTwo));

            string testThree = "badc";
            string testFour = "baba";
            Console.WriteLine($"Testing {testThree} & {testFour}"); //expect false 
            Console.WriteLine(new IsomorphicString().IsIsomorphic(testThree, testFour));

            string testFive = "paper";
            string testSix = "title";
            Console.WriteLine($"Testing {testFive} & {testSix}"); //expect true 
            Console.WriteLine(new IsomorphicString().IsIsomorphic(testThree, testFour));
        }
    }
}
