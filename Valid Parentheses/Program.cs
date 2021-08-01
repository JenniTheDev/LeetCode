using System;

// https://leetcode.com/problems/valid-parentheses/
namespace ValidParentheses {
    internal class Program {

        private static void Main(string[] args) {
            Solution answer = new Solution();
            string exOne = "()";
            Console.WriteLine(answer.IsValid(exOne));

            string exTwo = "(){}[]";
            Console.WriteLine(answer.IsValid(exTwo));

            string exThree = "(}";
            Console.WriteLine(answer.IsValid(exThree));

            string exFour = "([)]";
            Console.WriteLine(answer.IsValid(exFour));

            string exFive = "{[]}";
            Console.WriteLine(answer.IsValid(exFive));
        }
    }
}