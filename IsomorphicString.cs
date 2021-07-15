using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode {
    public class IsomorphicString {
        public Dictionary<char, char> letterPairs = new Dictionary<char, char>();
        public bool IsIsomorphic(string s, string t) {

            for (int i = 0; i < s.Length; i++) {
                // doesn't work for duplicate letters like egg and add
                if (letterPairs.TryAdd(s[i], t[i]) == false) {
                    return false;
                }
                
            }
            return true;
        }
    }
}

    
