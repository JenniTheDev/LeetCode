// Given a string s, find the length of the longest substring without repeating characters.


using System;
using System.Collections.Generic;

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (string.IsNullOrEmpty(s)) {
            return 0;
        }

        var startIndex = 0;
        var endIndex = 0;
        var length = 0;
        var charSet = new Dictionary<char, int>();
        while (endIndex < s.Length) {
            if (charSet.ContainsKey(s[endIndex])) {
                length = Math.Max(length, endIndex - startIndex);
                startIndex = charSet[s[endIndex]] + 1;
                endIndex = startIndex;
                charSet.Clear();
            } else {
                charSet.Add(s[endIndex], endIndex);
                endIndex++;
            }
        }
        length = Math.Max(length, endIndex - startIndex);

        return length;



    }
}