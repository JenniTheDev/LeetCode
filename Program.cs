using System;

namespace LeetCode {
    class Program {
        static void Main(string[] args) {
            string one = "egg";
            string two = "add";
            Console.WriteLine(new IsomorphicString().IsIsomorphic(one, two));

            string testThree = "badc";
            string testFour = "baba";
            Console.WriteLine($"Testing {testThree} & {testFour}"); //expect false 
            Console.WriteLine(new IsomorphicString().IsIsomorphic(testThree, testFour));
        }
    }
}
