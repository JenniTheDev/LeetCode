using System;
// https://leetcode.com/problems/valid-parentheses/
namespace ValidParentheses {
    class Program {
        static void Main(string[] args) {
            Solution answer = new Solution();
            string exOne = "()";
            Console.WriteLine(answer.IsValid(exOne));
        }
    }
}
