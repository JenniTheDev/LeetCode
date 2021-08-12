using System;
using System.Text.RegularExpressions;

// https://leetcode.com/problems/valid-palindrome/
namespace Valid_Palindrome {
    internal class Solution {
        private const string pattern = @"[\[\]\{\}\(\),`~'\;.:@?!#$%""^*\-_ ]";

        public bool IsPalindrome(string s) {
            s = s.ToLower();  // all to lower case
            s = s.Replace(" ", String.Empty); // remove all the space
            s = Regex.Replace(s, pattern, String.Empty); // remove the extra chars
            if (s.Length <= 1) {
                return true;
            }

            for (int i = 0; i < s.Length / 2; i++) {
                if (s[i] != s[s.Length - 1 - i]) {
                    return false;
                }
            }
            return true;
        }
    }
}