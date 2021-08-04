using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/problems/roman-to-integer/
namespace Roman_To_Integer {
    internal class Solution {

        public int RomanToInt(string s) {
            var romanNumDict = new Dictionary<char, int> {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 }
            };

            // int total = 0;
            s.ToCharArray();

            int prevNum = romanNumDict[s[s.Length - 1]];
            int total = prevNum;
            for (int i = s.Length - 2; i >= 0; i--) {
                if (romanNumDict[s[i]] < prevNum) {
                    total -= prevNum;
                } else {
                    total += romanNumDict[s[i]];
                }
                prevNum = romanNumDict[s[i]];
            }
            return total;
        }
    }
}