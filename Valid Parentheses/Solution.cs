using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses {
    internal class Solution {

        public bool IsValid(string s) {
            var pairDict = new Dictionary<char, char>();
            pairDict.Add('(', ')');
            pairDict.Add('[', ']');
            pairDict.Add('{', '}');

            Stack<char> bracketsChecked = new Stack<char>();

            for (int i = 0; i < s.Length; i++) {
                if (pairDict.ContainsKey(s[i])) {
                    bracketsChecked.Push(s[i]);
                } else {
                    if (bracketsChecked.Count == 0) {
                        return false;
                    }
                    if (pairDict[bracketsChecked.Peek()] == s[i]) {
                        bracketsChecked.Pop();
                    } else {
                        return false;
                    }
                }
            }
            if (bracketsChecked.Count == 0) {
                return true;
            } else return false;
        }
    }
}