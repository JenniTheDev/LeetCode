using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/explore/challenge/card/july-leetcoding-challenge-2021/609/week-2-july-8th-july-14th/3811/

namespace LeetCode {
    public class IsomorphicString {
       
        public bool IsIsomorphic(string s, string t) {
            var chars = new Dictionary<char, char>();
            char firstChar, secondChar;
            bool isFirstCharInKeys;

            for (int i = 0; i < s.Length; i++) {
                firstChar = s[i];
                secondChar = t[i];
                isFirstCharInKeys = IsFirstCharInKeys(ref chars, firstChar);

                if (!isFirstCharInKeys && !chars.ContainsValue(secondChar)) {
                    chars.Add(firstChar, secondChar);
                } else if (!isFirstCharInKeys || chars[firstChar] != secondChar) {
                    return false;
                }
            }

            return true;
        }

        private bool IsFirstCharInKeys(ref Dictionary<char, char> chars, char firstChar) {
            return chars.ContainsKey(firstChar);
        }

    }
    
}

    
