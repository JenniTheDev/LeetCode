using System;
using System.Collections.Generic;

// https://leetcode.com/problems/longest-substring-without-repeating-characters

namespace LongestSubstringWithoutRepeating {
    class Solution {
        public int LengthOfLongestSubstring(string s) {
            int substringLength = 0;
            int longestSubstring = 0;
            HashSet<char> letterLookup = new HashSet<char>();
            int startingLocation = 0;

            if (s.Length == 1) {
                longestSubstring = 1;
                return longestSubstring;
            }

            for (int i = 0; i < s.Length; i++) {
                if (letterLookup.Add(s[i]) == true) {
                    substringLength++;
                } else {
                    letterLookup.Clear();
                    substringLength = 0;
                    startingLocation++;
                    i = startingLocation-1;  // 
                }
                if (substringLength > longestSubstring) {
                    longestSubstring = substringLength;
                }
            }



            return longestSubstring;
        }
    }
}
