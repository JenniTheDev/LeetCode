using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/explore/challenge/card/july-leetcoding-challenge-2021/609/week-2-july-8th-july-14th/3811/

namespace LeetCode {
    public class IsomorphicString {
        public Dictionary<char, char> letterPairs = new Dictionary<char, char>();
        public bool IsIsomorphic(string s, string t) {
            if (s.Length != t.Length) {
                return false;
            }

            for (int i = 0; i < s.Length; i++) {
                if (letterPairs.TryAdd(s[i], t[i]) == false) {
                    if (letterPairs[s[i]] != t[i] )
                    return false;    
                }
            }
            return true;
        }
    }
}

    
