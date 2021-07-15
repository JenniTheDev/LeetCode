using System;

// https://leetcode.com/problems/palindrome-number/

namespace LeetCode{
    internal class PalindromeNumberSolution {
        public bool IsPalindrome(int x) {
            if (x < 0) {
                return false;
            }

            string xAsAString = x.ToString();

            for (int i = 0; i < xAsAString.Length; i++) {
                if (xAsAString[i] != xAsAString[xAsAString.Length - 1 - i]) {
                    return false;
                }
            }
            return true;
        }
    }
}